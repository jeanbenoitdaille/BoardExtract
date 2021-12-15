    using System;
     
    namespace Coding.Exercise
    {
        public class Exercise
        {
            public static Tuple<string, string[]> Main(){
               var foo = new string[] {"Hello", "I", "Am", "Learning", "C#"};
               
               var cSharpString = foo[4];
               
               foo[4] = "Arrays";
               
               return new Tuple<string, string[]>
                    (cSharpString, foo);
            }
        }
    }