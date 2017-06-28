namespace CC.modelo
{
    public struct Parametros
    {
        //Properties
        public int N { get; set; }
        public int M { get; set; }
        public int Dificultad { get; set; }

        //Constructor
        public Parametros(int N, int M, int dificultad)
        {
            this.N = N;
            this.M = M;
            Dificultad = dificultad;
        }

    }
}