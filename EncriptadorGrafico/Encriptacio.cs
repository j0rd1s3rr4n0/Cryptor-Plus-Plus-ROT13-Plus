using System.Collections;

namespace EncriptadorGrafico
{
    class Encriptacio
    {
        // ROT13
        private string texto = "";
        private int rot = 13;
        private string[] dictionary = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z, ,_,*,(,),=,.,/,\\,\",·,#,$,€,%,&,¬,?,¿,¡,!,:,;,-,ç,],},[,{,^,¨,',⌂".Split(',');
        private Dictionary<string, string> dict = new Dictionary<string, string>();


        public Encriptacio(string texto,int rotacion)
        {
            this.texto = texto.ToLower();
            this.rot = rotacion;
        }

        private string[] rotar()
        {
            string[] dicc = this.dictionary;
            string[] returned = new string[dicc.Length];
            ArrayList arr = new ArrayList();

            /*
             [ 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 ]
             |   |   |ROT|   |   |   |   |   |
             [ a | b | c | d | e | f | g | ... ]

             ROT2
             [ c | d | e | f | g |...|  a | b ]

             */



            //Añade del rot a final e dict
            for (int x = this.rot; x < dicc.Length; x++)
            {
                arr.Add(dicc[x]);
            }
            //SEGUNDA PARTE DE 12 a 0
            for (int y = 0; y < this.rot; y++)
            {
                arr.Add(dicc[y]);

            }
            for (int i = 0; i < arr.Count; i++)
            {
                returned[i] = arr[i].ToString()!;
                //Console.WriteLine(arr[i]+", ");
            }
            return returned;
        }

        public string decripter()
        {
            string[] sample = this.rotar();
            string[] dicty = this.dictionary;
            char[] newtext = texto.ToCharArray();

            string result = "";

            for (int x = 0; x < dicty.Length - 1; x++)
            {
                dict.Add(dicty[x], sample[x]);
            }
            for (int i = 0; i < newtext.Length; i++)
            {
                foreach (KeyValuePair<string, string> dato in dict)
                {
                    if (newtext[i].ToString() == dato.Value)
                    {
                        result += (dato.Key);
                    }
                }
            }
            return result;
        }

        public string crypt()
        {
            string[] sample = this.rotar();
            string[] dicty = this.dictionary;
            char[] newtext = texto.ToCharArray();

            string result = "";

            for (int x = 0; x < dicty.Length - 1; x++)
            {
                dict.Add(dicty[x], sample[x]);
            }
            for (int i = 0; i < newtext.Length; i++)
            {
                foreach (KeyValuePair<string, string> dato in dict)
                {
                    if (newtext[i].ToString() == dato.Key)
                    {
                        result += (dato.Value);
                    }
                }
            }
            return result;
        }

        public void setText(string texto)
        {
            this.texto = texto;
        }

        public string getText()
        {
            return texto;
        }
    }
}