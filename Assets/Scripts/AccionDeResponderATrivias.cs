using UnityEngine; 
using UnityStandardAssets.CrossPlatformInput; // include so we can use Cross-Platform Input (for mobile devices - i.e. Android, iOS, etc. - and for Standalone devices - Windows, Mac).

/// <summary>
/// Esta clase Maneja las acciones que realizará el videojuego cuando el jugador responda (o toque con sus dedos) las Respuestas a las Trivias, botones, etc.
/// 
/// </summary>
public class AccionDeResponderATrivias : MonoBehaviour 
{



    //private void Awake()
    //{
    //}//End Method

    //    // No conviene usar.
    //    private void Start() 
    //    {
    //        //
    //        //
    //        this.ReinicializarContador( true );
    //
    //    }//End Metodo



    #region Botones de: Preguntas y Respuestas


    public void RespuestasATriviasPreguntas(int numeroDePregunta, int numeroDeImagen)
    {

        // 
        //
        Debug.Log("RespuestasATriviasPreguntas... ojo debe salir otro DEBUG LOG más interno");


        switch (numeroDePregunta)
        {

            // Pregunta: 1
            //
            case 1:     // La del Centro: Será la Buena.


                switch (numeroDeImagen)
                {

                    case 1:

                        // Respuesta equivocada
                        //
                        Debug.Log("Pregunta 1, Resp. 1: Respuesta equivocada");

                        // Accion desde el GameManager
                        //
                        GameManager.gm.ResponderConFalloAPreguntaTrivia();

                        break;


                    // Respuesta Correcta:
                    //
                    case 2:

                        // 1-   Apagar / Esconder el Botón (para que no lo puedan presionar más).
                        //


                        // 2-   Ejecutar Acción adecuada:
                        //
                        // Accion desde el GameManager
                        //
                        GameManager.gm.ResponderConAciertoAPreguntaTrivia();


                        // Respuesta
                        //
                        Debug.Log("Pregunta 1, Resp. 2: Respuesta CORRECTA!");


                        break;


                    case 3:

                        // Respuesta equivocada
                        //
                        Debug.Log("Pregunta 1, Resp. 3: Respuesta equivocada");

                        // Accion desde el GameManager
                        //
                        GameManager.gm.ResponderConFalloAPreguntaTrivia();

                        break;

                    default:

                        // Error del Programador: avisar.
                        //
                        Debug.Log("Pregunta 1, Resp. ???: Respuesta No Programada!");

                        // Accion desde el GameManager
                        //
                        GameManager.gm.ResponderConFalloAPreguntaTrivia();

                        break;

                }//End switch 2 interno

                break;

            // Pregunta: 2
            //
            case 2:

                switch (numeroDeImagen)
                {

                    case 1:

                        // Respuesta
                        //
                        Debug.Log("Pregunta 2, Resp. 1: Respuesta CORRECTA!");

                        // Accion desde el GameManager
                        //
                        GameManager.gm.ResponderConAciertoAPreguntaTrivia();

                        break;


                    // Respuesta:
                    //
                    case 2:

                        // Respuesta equivocada
                        //
                        Debug.Log("Pregunta 2, Resp. 2: Respuesta equivocada");

                        // Accion desde el GameManager
                        //
                        GameManager.gm.ResponderConFalloAPreguntaTrivia();

                        break;


                    case 3:

                        // Respuesta equivocada
                        //
                        Debug.Log("Pregunta 2, Resp. 3: Respuesta equivocada");

                        // Accion desde el GameManager
                        //
                        GameManager.gm.ResponderConFalloAPreguntaTrivia();

                        break;


                    default:

                        // Error del Programador: avisar.
                        //
                        Debug.Log("Pregunta 2, Resp. ???: Respuesta No Programada!");

                        // Accion desde el GameManager
                        //
                        GameManager.gm.ResponderConFalloAPreguntaTrivia();

                        break;

                }//End switch 2 interno

                break;   // Case 2


            // Pregunta: 3
            //
            case 3:

                switch (numeroDeImagen)
                {

                    case 1:

                        // Respuesta equivocada
                        //
                        Debug.Log("Pregunta 2, Resp. 1: Respuesta equivocada");

                        // Accion desde el GameManager
                        //
                        GameManager.gm.ResponderConFalloAPreguntaTrivia();

                        break;


                    // Respuesta:
                    //
                    case 2:

                        // Respuesta equivocada
                        //
                        Debug.Log("Pregunta 2, Resp. 2: Respuesta equivocada");

                        // Accion desde el GameManager
                        //
                        GameManager.gm.ResponderConFalloAPreguntaTrivia();

                        break;


                    case 3:

                        // Respuesta
                        //
                        Debug.Log("Pregunta 2, Resp. 3: Respuesta CORRECTA!");

                        // Accion desde el GameManager
                        //
                        GameManager.gm.ResponderConAciertoAPreguntaTrivia();

                        break;


                    default:

                        // Error del Programador: avisar.
                        //
                        Debug.Log("Pregunta 3, Resp. ???: Respuesta No Programada!");

                        // Accion desde el GameManager
                        //
                        GameManager.gm.ResponderConFalloAPreguntaTrivia();

                        break;

                }//End switch 2 interno

                break;

            default:

                // Error del Programador: avisar.
                //
                Debug.Log("Pregunta 3, Resp. ???: Respuesta No Programada!");

                break;

        }//End switch 1

    }//End Method


    /// <summary>
    /// Acciones al responder la Trivia de PREGUNTA NRO. 1.
    /// </summary>
    /// <param name="numeroDeImagen"></param>
    public void RespuestasATriviasPregunta1(int numeroDeImagen)
    {

        // 
        //
        Debug.Log("RespuestasATriviasPreguntas... ojo debe salir otro DEBUG LOG más interno");

        switch (numeroDeImagen)
        {

            case 1:

                // Respuesta equivocada
                //
                Debug.Log("Pregunta 1, Resp. 1: Respuesta equivocada");

                // Accion desde el GameManager
                //
                GameManager.gm.ResponderConFalloAPreguntaTrivia();

                break;


            // Respuesta Correcta:
            //
            case 2:

                // 1-   Apagar / Esconder el Botón (para que no lo puedan presionar más).
                //


                // 2-   Ejecutar Acción adecuada:
                //
                // Accion desde el GameManager
                //
                GameManager.gm.ResponderConAciertoAPreguntaTrivia();


                // Respuesta
                //
                Debug.Log("Pregunta 1, Resp. 2: Respuesta CORRECTA!");

                break;


            case 3:

                // Respuesta equivocada
                //
                Debug.Log("Pregunta 1, Resp. 3: Respuesta equivocada");

                // Accion desde el GameManager
                //
                GameManager.gm.ResponderConFalloAPreguntaTrivia();


                break;

            default:

                // Error del Programador: avisar.
                //
                Debug.Log("Pregunta 1, Resp. ???: Respuesta No Programada!");

                break;

        }//End switch 2 interno

    }//End Method


    /// <summary>
    /// Acciones al responder la Trivia de PREGUNTA NRO. 2.
    /// </summary>
    /// <param name="numeroDeImagen"></param>
    public void RespuestasATriviasPregunta2(int numeroDeImagen)
    {

        // 
        //
        Debug.Log("RespuestasATriviasPreguntas... ojo debe salir otro DEBUG LOG más interno");


        switch (numeroDeImagen)
        {

            case 1:

                // Respuesta
                //
                Debug.Log("Pregunta 2, Resp. 1: Respuesta CORRECTA!");

                // Accion desde el GameManager
                //
                GameManager.gm.ResponderConAciertoAPreguntaTrivia();

                break;


            // Respuesta:
            //
            case 2:

                // Respuesta equivocada
                //
                Debug.Log("Pregunta 2, Resp. 2: Respuesta equivocada");

                // Accion desde el GameManager
                //
                GameManager.gm.ResponderConFalloAPreguntaTrivia();

                break;


            case 3:

                // Respuesta equivocada
                //
                Debug.Log("Pregunta 2, Resp. 3: Respuesta equivocada");

                // Accion desde el GameManager
                //
                GameManager.gm.ResponderConFalloAPreguntaTrivia();

                break;


            default:

                // Error del Programador: avisar.
                //
                Debug.Log("Pregunta 2, Resp. ???: Respuesta No Programada!");

                break;

        }//End switch 2 interno

    }//End Method



    /// <summary>
    /// Acciones al responder la Trivia de PREGUNTA NRO. 3.
    /// </summary>
    /// <param name="numeroDeImagen"></param>
    public void RespuestasATriviasPregunta3(int numeroDeImagen)
    {

        // 
        //
        Debug.Log("RespuestasATriviasPreguntas... ojo debe salir otro DEBUG LOG más interno");


        switch (numeroDeImagen)
        {

            case 1:

                // Respuesta equivocada
                //
                Debug.Log("Pregunta 2, Resp. 3: Respuesta equivocada");

                // Accion desde el GameManager
                //
                GameManager.gm.ResponderConFalloAPreguntaTrivia();

                break;


            // Respuesta:
            //
            case 2:

                // Respuesta equivocada
                //
                Debug.Log("Pregunta 2, Resp. 2: Respuesta equivocada");

                // Accion desde el GameManager
                //
                GameManager.gm.ResponderConFalloAPreguntaTrivia();

                break;


            case 3:

                // Respuesta
                //
                Debug.Log("Pregunta 2, Resp. 1: Respuesta CORRECTA!");


                // Accion desde el GameManager
                //
                GameManager.gm.ResponderConAciertoAPreguntaTrivia();

                break;


            default:

                // Error del Programador: avisar.
                //
                Debug.Log("Pregunta 3, Resp. ???: Respuesta No Programada!");

                break;

        }//End switch 2 interno


    }//End Method

    #endregion Botones de: Preguntas y Respuestas


}