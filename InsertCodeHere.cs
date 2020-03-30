namespace DrawShapes
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            int t1 = 1;
            int t2 = 1;
            int t3 = 1;
            //int t4 = 1;
            //int t4_2 = 2;
            // The FIRST line of code should be BELOW this line

            // SHAPE A (10 stars in a single row)
            //
            while (t1 < 11)
             {
                DrawingTool.DrawOneStar();
                t1 = t1 +1;
             }
            // **********

            DrawingTool.StartNewLine();  
            //

            // SHAPE B (5 stars in a single row, separated by spaces)
            //
            while (t2 < 6)
             {
                DrawingTool.DrawOneStar();
                DrawingTool.DrawOneSpace();
                t2 = t2+1;
             }
            // * * * * * 
            //
            DrawingTool.StartNewLine();

            // SHAPE C  (10 rows of 10 stars each)
            //
            while (t3 < 11)
             {
                DrawingTool.DrawOneStar();
                                DrawingTool.DrawOneStar();
                                                DrawingTool.DrawOneStar();
                                                                DrawingTool.DrawOneStar();
                                                                                DrawingTool.DrawOneStar();
                                                                                                DrawingTool.DrawOneStar();
                                                                                                                DrawingTool.DrawOneStar();
                                                                                                                                DrawingTool.DrawOneStar();
                                                                                                                                                DrawingTool.DrawOneStar();
                                                                                                                                                                DrawingTool.DrawOneStar();
                DrawingTool.StartNewLine();
                t3 = t3+1;
            
             }
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            //
            DrawingTool.StartNewLine();
            DrawingTool.StartNewLine();

            


            // SHAPE D (a triangle, I guess...)
            //
            // *
            // **
            // ***
            // ****
            // *****
            // ******
            // *******
            // ********
            // *********
            // **********
            //

            // SHAPE E (X)
            //
            // *        *
            //  *      * 
            //   *    *   
            //    *  *    
            //     **     
            //     **     
            //    *  *    
            //   *    *   
            //  *      * 
            // *        *

            for (int Collum = 0; Collum < 10; Collum++)
            {
                for(int row = 0; row < 10; row++)
                {
                if(row==Collum || row +Collum == 9)
                {
                    DrawingTool.DrawOneStar();
                }
                else
                DrawingTool.DrawOneSpace();
                }
                System.Console.WriteLine();

            }


            // The LAST line of code should be ABOVE this line

        }
    }
}