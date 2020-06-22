using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SelectionSort_Algorithm
{
    public partial class Selection_Sort : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] Arr = { 45, 3, 2, 4, 2, 9, 1 };
            Selection(Arr);
        }
        private void Selection(int[] Ar)
        {
            int a = Ar.Length;
            for (int i = 0; i < a-1; i++)
            {
                int min = i;
                for (int j = i+1; j < a; j++)
                {
                    if (Ar[j] < Ar[min])
                    {
                        min = j;
                    }
                }
                int temp = Ar[i];
                Ar[i] = Ar[min];
                Ar[min] = temp;
            }
            Response.Write("Array {");
            for (int i = 0; i < a; i++)
            {
                Response.Write(Ar[i]+" , ");
            }
            Response.Write("}");
        }
    }
}
