using System;

namespace sample1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //コンソールに文字列を表示
            Console.WriteLine("Hello World!");
            Console.WriteLine("こんにちは、世界");
            Console.WriteLine("うんちもれぞう");
            Console.WriteLine("ブンブンハロー、どうもヨシキンです！");

            Console.WriteLine();    //空白の行を追加（見やすいように）

            //変数の宣言と代入、int→数値を入れる変数
            int YoshikiAge;
            YoshikiAge = 21;

            int NaotoAge;
            NaotoAge = 20;

            //代入した変数をコンソールに表示
            Console.WriteLine("よしきの年齢は"+ YoshikiAge +"歳です。");
            Console.WriteLine("なおとの年齢は"+ NaotoAge +"歳です。");


            Console.WriteLine("-----------------------------------------");

            /*いろいろな表現の仕方
             変数の初期化*/

            int Yoshikiage = 21;    //18,19行目とやってることは同じ(小文字なのは同じ変数名が使えないため。)
            int Naotoage = 20;      //21,22行と同じ

            //25行目と同じ
            Console.WriteLine("よしきの年齢は{0}歳です。",Yoshikiage);
            //26行目と同じ
            Console.WriteLine("なおとの年齢は{0}歳です。",Naotoage);

            Console.WriteLine("-----------------------------------------");


            //条件分岐（if文）
            int yoshikiAge = 21;


            //もしもyoshikiAgeが20以上だった場合
            if (yoshikiAge >= 20)
            {
                Console.WriteLine("よしきは成人しています。");
            }
            //そうでない場合
            else
            {
                Console.WriteLine("よしきは未成年です。");
            }

            //ifとelseのどちらか当てはまるほうが処理される。
            //if(もし〜なら)
            //else if (もしくは〜なら) ←時々使う
            //else(それ以外の場合)

            Console.WriteLine("-----------------------------------------");
            //ループ
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("5回繰り返す。");
            }








        }

    }
}
