using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayBGM : MonoBehaviour
{
    [SerializeField] AudioClip BGM = null;//再生させる音楽であるAudioClipとの連携のために導入
    AudioSource Audio;//音楽を再生させるためにAudioSourceコンポーネントのPlayメソッドを使うために定義する
    void Start()
    {
        Audio = GetComponent<AudioSource>();//このスクリプトがアタッチされたオブジェクトに付与されているAudioSourceコンポーネントを認識させる
        Audio.PlayOneShot(BGM);//変数BGMが表す音楽を再生する
    }
}