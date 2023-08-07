class Juego{
    private static string _username{get;set;}
    private static int _puntajeActual{get;set;}
    private static int _cantidadPreguntasCorrectas{get;set;}
    private static List<Pregunta> _preguntas{get;set;}
    private static List<Respuesta> _respuestas{get;set;}
    
    public static void InicializarJuego(){
        
    }
    public static List<Categorias> ObtenerCategorias(){
        return BD.ObtenerCategorias();
    }
    public static List<Dificultades> ObtenerDificultades(){
        return BD.ObtenerDificultades();
    }
    public static void CargarPartida(string username, int dificultad, int categoria){

    }
    public static List<Pregunta> ObtenerProximaPregunta(){
        
        return ;  
    }
    public static void Respuestas(int idPregunta){

    }
    public static void VerificarRespuesta(int idPregunta, int idRespuesta){

    }
    public static void VerificarRespuesta(int idPregunta, int idRespuesta){

    }
}
