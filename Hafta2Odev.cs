using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{


    void bolenleriBul(int ilkSayi, int ikinciSayi)
    {
        ArrayList tumListe = new ArrayList();
        //ArrayList ikiyeBolunenler = new ArrayList();
        //ArrayList uceBolunenler = new ArrayList();
        //ArrayList dordeBolunenler = new ArrayList();
        //ArrayList beseBolunenler = new ArrayList();

        string tumListeString = "Tüm liste: ";
        string ikiyeBolunenlerString = "Ýkiye bölünenler: ";
        string uceBolunenlerString = "Üçe bölünenler: ";
        string dordeBolunenlerString = "Dörde bölünenler: ";
        string beseBolunenlerString = "Beþe bölünenler: ";

        for (int i = ilkSayi; i <= ikinciSayi; i++)
        {
            //tumListe.Add(i);
        }

        // listedeki tüm sayýlar için
        foreach (int i in tumListe)
        {
            // tüm liste stringe koyuyoruz
            tumListeString += "-" + i + " ";

            // modlarýndan kalana göre
            // ikiye tam bölünenler
            if (i % 2 == 0)
            {
                //ikiyeBolunenler.Add(i);
                ikiyeBolunenlerString += "-" + i + " ";
            }

            if (i % 3 == 0)
            {
                // üçe tam bölünenler
                //uceBolunenler.Add(i);
                uceBolunenlerString += "-" + i + " ";
            }

            // dörde tam bölünenler
            if (i % 4 == 0)
            {
                //dordeBolunenler.Add(i);
                dordeBolunenlerString += "-" + i + " ";
            }

            if ((i % 5) == 0)
            {
                // beþe tam bölünenler
                //beseBolunenler.Add(i);
                beseBolunenlerString += "-" + i + " ";
            }

        }

        print(tumListeString);
        print(ikiyeBolunenlerString);
        print(uceBolunenlerString);
        print(dordeBolunenlerString);
        print(beseBolunenlerString);


    }

    // Start is called before the first frame update
    void Start()
    {
        bolenleriBul(15, 130);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
