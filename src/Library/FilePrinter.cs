using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        private static int count = 0;
        // Modificado por DIP
        public void PrintRecipe(IRecipeContent recipe)
        {
            FilePrinter.count = FilePrinter.count + 1;
            File.WriteAllText("..\\..\\recetas_guardadas\\Recipe" + FilePrinter.count + ".txt", recipe.GetTextToPrint());
        }
    }
}