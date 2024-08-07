using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Practice4
{
    public class Car
    {
        private string _brand;          //marka
        private string _model;
        private string _color;
        private int _countDoor;         //kapı sayısı

        public Car(string brand, string model, string color, int countDoor)                 //4 parametreli bir ctor oluştururuldu
        {
            Brand = brand;
            Model = model;
            Color = color;
            CountDoor = countDoor;          //Propertye atama yaptık ki set metodu tetiklensin


        }

        //Property ler tanımlandı. 
        public string Brand { get { return _brand; } set { _brand = value; } }
        public string Model { get { return _model; } set { _model = value; } }
        public string Color { get { return _color; } set { _brand = value; } }
        public int CountDoor
        {                                              //Kapı sayısı set edilirken 2 ve ya 4 dışında girilirse kullanıcı ya uyarı verip kapı sayısa -1 atanacak.
            get
            {
                return _countDoor;
            }
            set
            {
                if (value == 2 || value == 4)
                {
                    _countDoor = value;
                }
                else
                {
                    Console.WriteLine("Yanlış kapı sayısı girdiniz");
                    _countDoor = -1;
                }
            }
        }

        public void InfoCar()                   //Arabaların bilgilerini ekrana yazdıracak metot
        {
            Console.WriteLine("Arabanın Markası : " + _brand + " Modeli :  " + _model + " Rengi : " + _color + " Kapı Sayısı : " + CountDoor);
        }






    }


}
