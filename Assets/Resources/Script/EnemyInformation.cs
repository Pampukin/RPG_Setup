using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;//情報を読み込むStringReaderを使用するために導入
//エネミーの基礎情報をCSVから読み込んで、変数に格納する
public class EnemyInformation//MonoBehaviourは継承しない
{
    static TextAsset csvFile;//CSVファイルを変数として扱うために宣言
    static List<string[]> enemyData = new List<string[]>();//CSVファイルの中身を入れる配列を定義。全てのデータが文字列形式で格納される
    //変数名[i]がエネミーIDがiの情報をそれぞれ示す
    public int[] enemyID = new int[100];//エネミーのID
    public string[] enemyName = new string[100];//エネミーの名前
    public int[] hp = new int[100];//エネミーのHP
    public string[] imageAddress = new string[100];//エネミーの画像イメージのアドレス
    //指定したアドレスに保管されているCSVファイルから情報を読み取り、enemyDataに情報を文字列として格納するメソッド。
    //enemyData[i][j]はCSVファイルのi行、j列目のデータを表す。但し先頭行（タイトル部分）は0行目と考えるものとする。
    static void CsvReader()
    {
        csvFile = Resources.Load("CSV/Basis9CSV") as TextAsset;//指定したファイルをTextAssetとして読み込み(ファイル名の.csvは不要なことに注意)　最初の行（タイトル部分）も読み込まれるのでそこは使用しない
        StringReader reader = new StringReader(csvFile.text);//
        while (reader.Peek() != -1)//最後まで読み込むと-1になる関数
        {
            string line = reader.ReadLine();//一行ずつ読み込み
            enemyData.Add(line.Split(','));//,区切りでリストに追加していく
        }
    }
    //enemyDataに一度CSVファイルのデータを読み込んだら他のプログラムから扱いやすいよう定義したenemyID等の変数にデータを格納する
    public void Init()
    {
        CsvReader();//enemyDataへ情報を一時格納
        //各変数へデータを格納
        for (int i = 1; i < enemyData.Count; i++)//エネミーIDが記述された最後まで読み込み。一行目はタイトルなのでi=0はデータとして扱わない
        {
            enemyID[i] = int.Parse(enemyData[i][0]);//string型からint型へ変換
            enemyName[i] = enemyData[i][1];
            hp[i] = int.Parse(enemyData[i][2]);
            imageAddress[i] = enemyData[i][3];
        }
    }
}