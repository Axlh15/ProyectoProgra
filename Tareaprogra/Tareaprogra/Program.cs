using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareaprogra
{
    public class Program
    {
        static void Main(string[] args)
        {
            Canción SiNosDejan  = new Canción();
            SiNosDejan.reproducciones = 7914102;
            SiNosDejan.año = 2020;                      //1
            SiNosDejan.duración = 2;
            SiNosDejan.album = "individual";

            Canción MiCielo = new Canción();
            MiCielo.reproducciones = 202264;
            MiCielo.año = 2023;                         //2
            MiCielo.duración = 3;
            MiCielo.album = "individual";

            Canción SomosAmigos = new Canción();
            SomosAmigos.reproducciones = 7914102;
            SomosAmigos.año = 2019;                     //3
            SomosAmigos.duración = 4;
            SomosAmigos.album = "Somos Amigos";

            Canción CuandoFuimosNada = new Canción();
            CuandoFuimosNada.reproducciones = 9691127;
            CuandoFuimosNada.año = 2029;                //4
            CuandoFuimosNada.duración = 4;
            CuandoFuimosNada.album = "Somos Amigos";

            Canción Cobarde = new Canción();
            Cobarde.reproducciones = 13630932;
            Cobarde.año = 2010;                         //5
            Cobarde.duración = 4;
            Cobarde.album = "Daltónico";

            Album Daltónico = new Album();
            Daltónico.canciones = 13;
            Daltónico.año = 2021;                       //6
            Daltónico.genero = "Rock";
            Daltónico.autor = "Enjambre";

            Album JotDog = new Album();
            JotDog.canciones = 11;
            JotDog.año = 2009;                          //7
            JotDog.genero = "Rock Pop";
            JotDog.autor = "Jot Dog";

            Album LoQueTeConteCuandoTeHaciasLaDormida = new Album();
            LoQueTeConteCuandoTeHaciasLaDormida.canciones = 15;
            LoQueTeConteCuandoTeHaciasLaDormida.año = 2003;                 //8
            LoQueTeConteCuandoTeHaciasLaDormida.genero = "Pop";
            LoQueTeConteCuandoTeHaciasLaDormida.autor = "La Oreja de Van Gogh";

            Album MansBestFriend = new Album();
            MansBestFriend.canciones = 7;
            MansBestFriend.año = 2021;                                      //9
            MansBestFriend.genero = "Indie";
            MansBestFriend.autor = "Cavetown";

            Album BothWaysOpenJaws = new Album();
            BothWaysOpenJaws.canciones = 13;
            BothWaysOpenJaws.año = 2011;                                    //10
            BothWaysOpenJaws.genero = "French Indie";
            BothWaysOpenJaws.autor = "The Dø";

            Artista Muse = new Artista();
            Muse.oyentesmensuales = 13547832;
            Muse.numalbums = 21;                                            //11
            Muse.topcancion = "Supermassive Black Hole";
            Muse.ultlanzamiento = "Euphoria";

            Artista PanicAtTheDisco = new Artista();
            PanicAtTheDisco.oyentesmensuales = 23103598;
            PanicAtTheDisco.numalbums = 11;                                 //12
            PanicAtTheDisco.topcancion = "High Hopes";
            PanicAtTheDisco.ultlanzamiento = "Dont let the light go out";

            Artista Kodaline = new Artista();
            Kodaline.oyentesmensuales = 8495399;
            Kodaline.numalbums = 6;                                         //13
            Kodaline.topcancion= "All i want";
            Kodaline.ultlanzamiento = "Brother";

            Artista TheMarias = new Artista();
            TheMarias.oyentesmensuales = 8901432;
            TheMarias.numalbums = 1;                                        //14
            TheMarias.topcancion = "Otro atardecer";
            TheMarias.ultlanzamiento = "Si me voy";

            Artista RexOrangeCounty = new Artista();
            RexOrangeCounty.oyentesmensuales = 13565279;
            RexOrangeCounty.numalbums = 5;
            RexOrangeCounty.topcancion = "THE SHADE";
            RexOrangeCounty.ultlanzamiento = "Threat";



        }
    }
}
