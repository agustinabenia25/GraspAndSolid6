namespace Full_GRASP_And_SOLID
{
    public class Notifier : TimerClient
    {
    /// <summary>
    /// El Dependency Inversion Principle (DIP) es la razón por la cual fue necesario
    /// agregar esta nueva clase al programa.
    /// Según este principio, las clases de alto nivel no deben depender de las de
    /// bajo nivel. Por lo tanto, esta clase es la abstracción que se asegura de que
    /// la clase Recipe no dependa de CountdownTimer.
    /// </summary>
        public Recipe recipe { get ; set ;}

        public Notifier(Recipe recipe)
        {
            this.recipe = recipe;
        }
        public void TimeOut()
        {
            this.recipe.TimerDone();
        }
    }
}