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

        string tumListeString = "T�m liste: ";
        string ikiyeBolunenlerString = "�kiye b�l�nenler: ";
        string uceBolunenlerString = "��e b�l�nenler: ";
        string dordeBolunenlerString = "D�rde b�l�nenler: ";
        string beseBolunenlerString = "Be�e b�l�nenler: ";

        for (int i = ilkSayi; i <= ikinciSayi; i++)
        {
            //tumListe.Add(i);
        }

        // listedeki t�m say�lar i�in
        foreach (int i in tumListe)
        {
            // t�m liste stringe koyuyoruz
            tumListeString += "-" + i + " ";

            // modlar�ndan kalana g�re
            // ikiye tam b�l�nenler
            if (i % 2 == 0)
            {
                //ikiyeBolunenler.Add(i);
                ikiyeBolunenlerString += "-" + i + " ";
            }

            if (i % 3 == 0)
            {
                // ��e tam b�l�nenler
                //uceBolunenler.Add(i);
                uceBolunenlerString += "-" + i + " ";
            }

            // d�rde tam b�l�nenler
            if (i % 4 == 0)
            {
                //dordeBolunenler.Add(i);
                dordeBolunenlerString += "-" + i + " ";
            }

            if ((i % 5) == 0)
            {
                // be�e tam b�l�nenler
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
