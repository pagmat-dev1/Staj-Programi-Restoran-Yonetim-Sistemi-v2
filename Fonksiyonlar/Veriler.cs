using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran_Yonetim_Sistemi_v2.Fonksiyonlar
{
    internal class Veriler
    {

        public readonly List<string> meyveler = new List<string> { "Elma", "Armut", "Muz", "Kiraz" };

        public readonly List<string> sebzeler = new List<string> { "Domates", "Patlıcan", "Salatalık", "Biber" };

        public readonly List<string> icecekler = new List<string> { "Su", "Kola", "Fanta", "Ayran" };

        public readonly List<string> yemekler = new List<string> { "Kuru Fasulye", "Pilav", "Makarna", "Köfte" };

        public readonly List<string> tatlilar = new List<string> { "Baklava", "Kadayıf", "Sütlaç", "Kazandibi" };

        public readonly List<string> fastfood = new List<string> { "Hamburger", "Patates Kızartması", "Nugget", "Tavukburger" };

        //string secilenMeyve = meyveler[1]; // Bu "Armut" dönecektir

    }
}
