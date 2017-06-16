namespace CC.modelo
{
    public struct Coords
    {
        public int Fila{get; set;}
        public int Columna { get; set; }

        public Coords(int fila, int columna)
        {
            Fila = fila;
            Columna = columna;
        }

    }
}