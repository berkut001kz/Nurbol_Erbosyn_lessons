﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Base_Lessons
{
    class Try_Catch_Finally
    {


        /*
         Мәзір
        #1 Try / Catch / Finally - Түсініктеме
            #1.1 Try - Қолданылуы
            #1.2 Catch - Қолданылуы
            #1.3 Exception қолданылуы
            #1.4 Finally - Қолданылуы
            #1.5 Қолдан қате шығару
         */


        //#1 Try / Catch / Finally - Түсініктеме


        public static void TryCatchFinally()
        {


            // Қазақ әріптерін дұрыс шығару үшін қажет
            Console.OutputEncoding = Encoding.UTF8;

            // Мысал 1 - Әріп жазған жағдайда қате шығады
            Console.WriteLine();
            Console.WriteLine("Мысал 1 - Әріп жазған жағдайда қате шығады ");
            Console.Write("Жасыңызды еңгізініз: ");
            string inputAge = Console.ReadLine(); // Пайдаланушыдан жасын сұрайды ол жасын тергенше күтіп тұрады
            int age = int.Parse(inputAge); // Түрлендіру - өткен сабақта өткенбіз - string => int
            Console.WriteLine("Сіздің еңгізген жасыңыз: " + age); // Еңгізген жасыңызды қайтарып шығырамыз

            /* 
             * Қазір еңгізу жолына әріп қосып жіберсек қате шығады 
                Себебі: біз қабылдап алатын айнымалының түрі int 
                Адамның жасы сан болғандықтан 
                int етіп өзіміз түрлендірген болатынбыз 



                Егер пайдаланушы байқамай немесе әйдеиі Әріп қосып жіберсе онда қате шығады және қатенің неден болғаның жасырмай шығарып береді

                ал кодты білетін пайдаланушы оны байқаса онда қауіп тудырады 
                жасырмай шыққан қатеден кінәрат тауып бағдарламаға бұзып кіруі мүмкін

                ал жәй пайдаланушы көрсе онда не болғаның түсінбей бағдарламаны қолдануды тоқтатуы мүмкін


                Енді не істеу керек?
                Енді не істеу керек?
                Енді не істеу керек?

                Шешімі бар бағдарламаны қорғай отырып қатені бұрмалап түсінікті етіп шығаруға болады.

                Ол қалай?
                Ол қалай?
                Ол қалай?

                Кодты алдымен тексеріп сосын қате боламаса шығаруға болады 
                Кодта қате шыққан жағдайда оны қағып алып өгертуге мүмкіндік береді

                Қатені жасырмасақ болмайды 

                Ол үшін бізге көмекке Try / Catch / Finally қажет болады

                Try - Кодты алдымен тексеріп сосын қате боламаса шығарады
                Catch - Кодта қате шыққан жағдайда оны қағып алып жасырып орнына басқа мәтің беруге мүмкіндік береді
                Finally - Кодты аяқтап нәтижесін алуға мүмкіндік береді - бұл болмаса бірінші қате шыққан бойда код тоқтап қалады









                Мысал 2 - #1.1 Try - Қолданылуы - #1.2 Catch - Қолданылуы

                Қате жазған жағдайда қатені жасырып түсінікті етіп өзгертіп бағдарламаны қорғап қалу
            */
            try
            {
                //#1.1 Try - Қолданылуы

                //Try - Кодты алдымен тексеріп сосын қате боламаса шығарады

                Console.WriteLine();
                Console.WriteLine("Мысал 2 - #1.1 Try - Қолданылуы - #1.2 Catch - Қолданылуы");
                Console.Write("Жасыңызды еңгізініз: ");
                string inputAge2 = Console.ReadLine(); // Пайдаланушыдан жасын сұрайды ол жасын тергенше күтіп тұрады
                int age2 = int.Parse(inputAge2); // Түрлендіру - өткен сабақта өткенбіз - string => int
                Console.WriteLine("Сіздің еңгізген жасыңыз: " + age2); // Еңгізген жасыңызды қайтарып шығырамыз
            }
            catch
            {
                //#1.2 Catch - Қолданылуы

                //Catch - Кодта қате шыққан жағдайда оны қағып алып жасырып түсінікті етіп өзгертуге мүмкіндік береді

                Console.WriteLine("Қатені жасырып қалдық: Бірдеме дұрыс емес");

            }












            /*Мысал 3 - #1.3 Exception қолданылуы
             * 
             * Егер біз пайдаланушыға қате неден болғаның көрсетпек болсақ 
             * catch(Exception e) - (Exception name) осылай жазып қатені көрсетсек болады
            */
            try
            {
                //#1.1 Try - Қолданылуы

                //Try - Кодты алдымен тексеріп сосын қате боламаса шығарады

                /*Мысал 3 - Егер біз пайдаланушыға қате неден болғаның көрсетпек болсақ 
                 * catch(Exception kate) - (Exception name) осылай жазып қатені көрсетсек болады
                */
                Console.WriteLine();
                Console.WriteLine("Мысал 3 - #1.3 Exception қолданылуы - Егер біз пайдаланушыға қате неден болғаның көрсетпек болсақ");
                Console.Write("Жасыңызды еңгізініз: ");
                string inputAge2 = Console.ReadLine(); // Пайдаланушыдан жасын сұрайды ол жасын тергенше күтіп тұрады
                int age2 = int.Parse(inputAge2); // Түрлендіру - өткен сабақта өткенбіз - string => int
                Console.WriteLine("Сіздің еңгізген жасыңыз: " + age2); // Еңгізген жасыңызды қайтарып шығырамыз
            }
            catch(Exception kate)
            {

                /*Мысал 3 - #1.3 Exception қолданылуы
                 * Егер біз пайдаланушыға қате неден болғаның көрсетпек болсақ 
                 * catch(Exception kate) - (Exception name) осылай жазып қатені көрсетсек болады
                 * 
                 * Қатенің себебін еш уақытта пайдаланушыға айтпайды
                 * 
                 * kate.Message - осы қатенің себебін өзімізге сақтап алуымыз керек серверге  кейін қате болса жөңдеп отырамыз
                 * 
                 * бірақ еш уақытта қатенің себебін пайдаланушыға айтуға болмайды 
                 * қатені бұрмалап  басқаша өзгертіп қате шыққаның түсінікті тілде айтуымыз керек
                */

                Console.WriteLine("Қате: " + kate.Message);

            }












            //Мысал 4 - #1.4 Finally - Қолданылуы


            /*Finally - Кодты аяқтап нәтижесін алуға мүмкіндік береді
             кодтан қате шықсын, шықпасын кодты аяқтауымыз керек
                try \ catch \ finally - Осы үшеуі қатар жүреді
             */
            try
            {

                Console.WriteLine();
                Console.WriteLine("Мысал 4 - #1.4 finally Қолданылуы - finally - мен бәрін жауып аяқтау керек ");
                Console.Write("Жасыңызды еңгізініз: ");
                string inputAge2 = Console.ReadLine(); 
                int age2 = int.Parse(inputAge2); 
                Console.WriteLine("Сіздің еңгізген жасыңыз: " + age2); 
            }
            catch
            {

                Console.WriteLine("Қатені жасырып қалдық: Бірдеме дұрыс емес");

            }
            finally
            {

                /* #1.4 Finally - Қолданылуы
                 * 
                 Егер серверге 10 сурет жүктесек олардын біреуінең қате шығатын болса қалған суреттер жүктелмей тоқтап қалады
                
                    finally - сол 1 қатеге қарамастан жұмысты толық атқарып шығады  
                    Нәтижесінде жұмысты аяқталғаның хабарлайды

                    Ал шыққан қатені e.Message осы арқылы сақтап алып сол пайдаланушыға ескерту бересіз осы сурет жүктелмей қалды деген сияқты
                    ал қалған суреттерді жалғасты жүктейбереді finally

                    try - ішінде ашатынды ашып тексеретінді тексеріп 
                
                     catch - ішінде қате болса ескертуін беріп

                     finally - мен бәрін жауып аяқтау керек 

                    try - ішінде ашылған құжат болмаса басқа болсын жабылуы қажет жабылмай қалса солай қалып койады кейін ол үлкен қате болады


                 */

                Console.WriteLine("Жұмыс аяқталды");
            }













            //Мысал 5 - #1.5 Қолдан қате шығару

            try
            {
                Console.WriteLine();
                Console.WriteLine("Мысал 5 - #1.5 Қолдан қате шығару");
                Console.Write("Жасыңызды теріңіз: ");
                string inputAge5 = Console.ReadLine();
                int age5 = int.Parse(inputAge5);

                //Мысал 5 - #1.5 Қолдан қате шығару

                if (age5 < 1) // Егер сіздің жасыңыз 1-ден кіші болса 
                {
                    throw new Exception("Қате: Жасыңыз 1-ден кіші болмасын");

                    // Қателердін бәрін бір жерге сақтау үшін жаңадан нысан құрамыз throw new Exception(value);
                }

                Console.WriteLine("Сіздің жасыңыз: " + age5);
            }
            catch(Exception e)
            {
                // Қателердін бәрін бір жерге сақтау үшін жаңадан нысан құрған едік енді сол нысанға берген мәтінді e.Message осы арқылы шығарамыз қате ретінде
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Жұмыс аяқталды");
            }




        }




    }
}
