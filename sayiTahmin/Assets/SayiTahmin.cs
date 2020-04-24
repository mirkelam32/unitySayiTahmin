using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SayiTahmin : MonoBehaviour
{
    int max = 100;
    int min = 1;
    int tahmin = 58;
    // Start is called before the first frame update
    void Start()
    {
        

        Debug.Log("Hoşgeldiniz.. Sayı Tahmin Oyununa");
        Debug.Log("bir sayı seç. Ne olduğunu tahmin edeceğim");
        Debug.Log("en düşük sayı değeri " + min);
        Debug.Log("en yüksek sayı tahmini "+ max);
        Debug.Log("tuttuğun sayıyı yönetmek için ok tuşlarını kullan. alt üst enter " + tahmin);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
           // Debug.Log("üst ok tuşuna bastınız.");
            min = tahmin;
            tahmin = (max + min) / 2;
            Debug.Log("tuttuğun sayı yüksek mi düşük mü ? " + tahmin);
            
            
        }
       else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
           // Debug.Log("alt ok tuşuna bastınız.");
            max = tahmin;
            tahmin = (max + min) / 2;
            Debug.Log("tuttuğun sayı yüksek mi düşük mü ? " + tahmin);
            
            
        }

       else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("ben kazandım tuttuğun sayı.. " + tahmin);
           }


    }
}
