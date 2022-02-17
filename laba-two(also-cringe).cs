using System;
class HelloWorld 
{
static void Main(string[] args)

  int a;
  int b;
  int c;
  int d;


  for(a = 1; a < 9;)
{
     for(b = 0; b < 9;)
   { 
         for(c = 0; c < 9;) 
      {     
          for(d = 0; d < 9;)
          {         
              if (a != b & a != c & a != d & b != c & b != d)
        {
            Consloe.Write(a);
            Consloe.Write(b);
            Consloe.Write(c);
            Consloe.Write(d);
          }
      }
}
}
}
}
