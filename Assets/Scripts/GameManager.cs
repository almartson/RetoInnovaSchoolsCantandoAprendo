using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
//using System.Collections;
// No necesario acá:   
//using UnityStandardAssets.CrossPlatformInput; // include so we can use Cross-Platform Input (for mobile devices - i.e. Android, iOS, etc. - and for Standalone devices - Windows, Mac).
using UnityEngine.SceneManagement;
/////using UnityEngine.Profiling;    // Profiler: COMENTAR CUANDO YA NO SE USE:
//
// Karaoke:
//
using Hammerplay.Utils.Karaoke;

public class GameManager : MonoBehaviour
{

    #region Atributos

    public static GameManager gm;


    #region Estados de Juego

    /// <summary>
    /// Estados del Juego Globales, por encima de todo.
    /// </summary>
    public enum _GAME_STATES { Playing, BeatLevel, Death, GameOver };

    /// <summary>
    /// Estados del Juego particulares: durante el ""gameState"": PLAYING.
    /// </summary>
    public enum _GAME_STATES_WHEN_PLAYING { InicializacionFinalVariables, AntesDeIniciarCancion, AntesDeIniciarCantoDeLaCancion, DuranteLaCancion, FinalizadaLaLetraDeLaCancion, FinalizadaLaCancion /*AnimacionInicioSuddenDeath */ };


    /// <summary>
    /// Estado Global del Juego.
    /// </summary>
    [Tooltip("Estado Global del Juego.")]
    public _GAME_STATES _mainGameState = _GAME_STATES.Playing;

    /// <summary>
    /// Estado Particular del Juego en PLAYING.
    /// </summary>
    [Tooltip("Estado Particular del Juego en PLAYING.")]
    public _GAME_STATES_WHEN_PLAYING _gameStateWhenPlaying = _GAME_STATES_WHEN_PLAYING.InicializacionFinalVariables;


    /// <summary>
    /// Numero de TRIVIAS o Preguntas
    /// </summary>
    public const int _MI_NUMERO_DE_TRIVIAS_O_PREGUNTAS = 3;


    /// <summary>
    /// Constantes de los TAGS para encontrar la GUI DE TRIVIAS
    /// </summary>
    public const string _MI_TRIVIA_1_GUI_CANVAS_TAG = "Trivia1GUIGameObject";
    public const string _MI_TRIVIA_2_GUI_CANVAS_TAG = "Trivia2GUIGameObject";
    public const string _MI_TRIVIA_3_GUI_CANVAS_TAG = "Trivia3GUIGameObject";


    #endregion Estados de Juego

    #region Configuración del Juego

    //  DIFICULTAD

    /// <summary>
    /// Dificultad del Juego: FÁCIL, NORMAL o DIFICIL.
    /// </summary>
    //[Tooltip("Dificultad del Juego: FÁCIL, NORMAL o DIFICIL.")]
    public enum _DIFICULTAD_DEL_JUEGO { FACIL, NORMAL, DIFICIL };

    /// <summary>
    /// Dificultad del Juego: FÁCIL, NORMAL o DIFICIL.
    /// </summary>
    [Tooltip("Dificultad del Juego: FÁCIL, NORMAL o DIFICIL.")]
    public _DIFICULTAD_DEL_JUEGO _miDificultadDelJuegoElegida = _DIFICULTAD_DEL_JUEGO.FACIL;


    /// <summary>
    /// (readonly, no modificar)
    /// Si GANÓ el JUEGO: es TRUE.
    /// PERDIÓ el JUEGO: es FALSE.
    /// </summary>
    [Tooltip("(Readonly, no modificar)\nSi GANÓ el JUEGO: es TRUE.\nPERDIÓ el JUEGO: es FALSE.")]
    public bool _miResultadoDelJuegoGaneOPerdi = false;


    #region Corrutinas - Optimización
    #endregion Corrutinas - Optimización


    #region Render - Graphics

    #region Resolucion de Pantalla - Calidad

    // Calidad de RESOLUCION: Opciones.

    /// <summary>
    /// Calidad de: RESOLUCION de PANTALLA a usar en la App. Valor PORCENTUAL.
    /// </summary>
    public enum _CALIDAD_DE_RESOLUCION_PANTALLA { LD = 60, MD = 80, HD = 100 };

    /// <summary>
    /// Calidad de: RESOLUCION de PANTALLA a usar en la App. Valor PORCENTUAL:
    /// 100 =>  HD
    /// 80  =>  MD
    /// 60  =>  LD
    /// </summary>
    [Tooltip("Calidad de: RESOLUCION de PANTALLA a usar en la App. Valor PORCENTUAL:\n* 100 =>  HD\n* 80  =>  MD\n* 60  =>  LD")]
    public _CALIDAD_DE_RESOLUCION_PANTALLA _miCalidadDeResolucionPantalla = _CALIDAD_DE_RESOLUCION_PANTALLA.MD;


    /// <summary>
    /// Tamano NATIVO de la pantalla (del dispositivo). X
    /// </summary>
    private float _miTamanoPantallaX = 800.0f;

    /// <summary>
    /// Tamano NATIVO de la pantalla (del dispositivo). Y
    /// </summary>
    private float _miTamanoPantallaY = 600.0f;


    /// <summary>
    /// FPS establecido para la App.
    /// </summary>
    public static readonly int _MI_FPS_CONSTANTE_MOBILE = 30;

    /// <summary>
    /// FPS establecido para la App.
    /// </summary>
    public static readonly int _MI_FPS_CONSTANTE_STANDALONE = 60;

    #endregion Resolucion de Pantalla - Calidad


    #region Quality Settings

    /// <summary>
    /// Calidad de: QUALITY SETTINGS a usar en la App.
    /// </summary>
    public enum _CALIDAD_DE_QUALITY_SETTINGS { NON_INITIALIZED_INHERIT_FROM_ABOVE_METHODS = -1, VERY_LOW = 0, LOW = 1, MEDIUM = 2, HIGH = 3, VERY_HIGH = 4, ULTRA = 5 };

    /// <summary>
    /// Calidad de: QUALITY SETTINGS a usar en la App.
    /// </summary>
    [Tooltip("Calidad de: QUALITY SETTINGS a usar en la App.")]
    public _CALIDAD_DE_QUALITY_SETTINGS _miCalidadDeQualitySettings = _CALIDAD_DE_QUALITY_SETTINGS.MEDIUM;

    #endregion Quality Settings

    #endregion Render - Graphics

    #endregion Configuración del Juego


    #region Objetos del Juego

    /// <summary>
    /// El GameObject HEROE acá será el: VIDEO de Karaoke.
    /// </summary>
    [Tooltip("El GameObject HEROE acá será el: VIDEO de Karaoke.")]
    public VideoPlayer _miVideoPlayer;

    /// <summary>
    /// El GameObject HEROE acá será el: Script de Karaoke. \nPodrá enviar señales de que debe empezar un Contador de Tiempo (i.e.: una TRIVIA).
    /// </summary>
    [Tooltip("El GameObject HEROE acá será el: Script de Karaoke. \nPodrá enviar señales de que debe empezar un Contador de Tiempo (i.e.: una TRIVIA).")]
    public Karaoke _miScriptKaraokeGameObjectPlayer;


    //[Tooltip("El BALON. Por defecto este deberia ser el Balon.")]
    //public GameObject _miPlayer;


    #endregion Objetos del Juego

    #region Estados de Juego | Jugadores | Puntuaciones


    #region CRONOMETRO, tiempo con cada TRIVIA:

    /// <summary>
    /// Tiempo máximo del Cronómetro a contar para dejar que el Jugado haga 'Toque' sobre las Imágenes.
    /// </summary>
    public const float _MI_TIEMPO_MAXIMO_CRONOMETRO_TRIVIA_1 = 7.0f;

    /// <summary>
    /// Tiempo máximo del Cronómetro a contar para dejar que el Jugado haga 'Toque' sobre las Imágenes.
    /// </summary>
    public const float _MI_TIEMPO_MAXIMO_CRONOMETRO_TRIVIA_2 = 7.0f;

    /// <summary>
    /// Tiempo máximo del Cronómetro a contar para dejar que el Jugado haga 'Toque' sobre las Imágenes.
    /// </summary>
    public const float _MI_TIEMPO_MAXIMO_CRONOMETRO_TRIVIA_3 = 7.0f;

    /// <summary>
    /// Tiempo máximo del Cronómetro a contar para dejar que el Jugado haga 'Toque' sobre las Imágenes.
    /// </summary>
    public static readonly float[] _MIS_TIEMPOS_MAXIMO_CRONOMETRO_TODAS_LAS_TRIVIAS = { _MI_TIEMPO_MAXIMO_CRONOMETRO_TRIVIA_1, _MI_TIEMPO_MAXIMO_CRONOMETRO_TRIVIA_2, _MI_TIEMPO_MAXIMO_CRONOMETRO_TRIVIA_3 };
    

    /// <summary>
    /// Script de TIMER o CRONOMETRO, para contar el Tiempo de la Frase/TRIVIA actualmente en Pantalla.
    /// </summary>
    [Tooltip("Script de TIMER o CRONOMETRO, para contar el Tiempo de la Frase/TRIVIA actualmente en Pantalla.")]
    [HideInInspector]
    public ConteoDeTiempo _miScriptConteoDeTiempo;


    #endregion CRONOMETRO, tiempo con cada TRIVIA:



    #region Puntuaciones de los Jugadores

    /// <summary>
    /// Puntuacion SCORE del jugador (OJO: No son los goles, sino Puntos-ORO de Juego). Incluye la toma de Bonos que aparezcan en el camino.
    /// </summary>
    public int _scorePuntosOroP1 = 0;

    #endregion Puntuaciones de los Jugadores
    #endregion Estados de Juego | Jugadores | Puntuaciones


    #region GUI

    #region Menu PAUSE / LET'S PLAY

    /// <summary>
    /// GUI Canvas TRIVIA 1
    /// </summary>
    [Tooltip("Componente CANVAS (GUI) del GameObject de GUI de: 'PREGUNTAS TRIVIA 1'\n * Para Activar / Desactivar de forma eficiente la GUI, evitando el método OnEnable()/OnDisable().")]
    public Canvas _miGUITrivia1GUIComponenteCanvasEnGameObjectCanvas;

    /// <summary>
    /// GUI Canvas TRIVIA 2
    /// </summary>
    [Tooltip("Componente CANVAS (GUI) del GameObject de GUI de: 'PREGUNTAS TRIVIA 2'\n * Para Activar / Desactivar de forma eficiente la GUI, evitando el método OnEnable()/OnDisable().")]
    public Canvas _miGUITrivia2GUIComponenteCanvasEnGameObjectCanvas;

    /// <summary>
    /// GUI Canvas TRIVIA 3
    /// </summary>
    [Tooltip("Componente CANVAS (GUI) del GameObject de GUI de: 'PREGUNTAS TRIVIA 3'\n * Para Activar / Desactivar de forma eficiente la GUI, evitando el método OnEnable()/OnDisable().")]
    public Canvas _miGUITrivia3GUIComponenteCanvasEnGameObjectCanvas;

    /// <summary>
    /// Array de Objetos de: GUI Canvas TRIVIAs
    /// </summary>
    [Tooltip("Componente CANVAS (GUI) del GameObject de GUI de: 'PREGUNTAS TRIVIA 1'\n * Para Activar / Desactivar de forma eficiente la GUI, evitando el método OnEnable()/OnDisable().")]
    private Canvas[] _miListaDeGUITriviasGUIComponenteCanvasEnGameObjectCanvas = new Canvas[_MI_NUMERO_DE_TRIVIAS_O_PREGUNTAS];

    #endregion Menu PAUSE / LET'S PLAY

    #region Control y Botones de Menu del Juego
    #endregion Control y Botones de Menu del Juego

    #endregion GUI


    #region Variables de Animaciones
    /// <summary>
    /// Variable marca el tiempo maximo para la ANIMACION de GOOOL
    /// </summary>
    ///private readonly float _TIEMPO_DELTA_OFFSET_DETENER_ANIMACION_GOL_Y_NO_GOL = 0.5f;    

    // Variables para CONTROLAR ANIMACIONES  (ANIMATOR PARAMETERS): 
    //   Uno por cada 'Animation Clip' o Animacion posible:
    //
    /// <summary>
    /// Nombre en 'Hash' del 'Animation State' de cuando el Personaje-Portero (CPU u Humano Player-P1) está  QUIETO-TRANQUILO in hacer nada (Estado DEFAULT).
    /// </summary>
    ///private static readonly int _PORTERO_IDLE_TRIGGER_PARAMETER_ANIMATION_STATE_HASH = Animator.StringToHash("triggerAnimacionPorteroIdle");


    #region Fuegos Artificiales Ganador

    /// <summary>
    /// GameObject de FUEGOS ARTIFICIALES.
    /// </summary>
    [Tooltip("GameObject de FUEGOS ARTIFICIALES.")]
    public GameObject _miGameObjectFuegosArtificiales;


    #endregion Fuegos Artificiales Ganador


    #region Camara y Animaciones

    /// <summary>
    /// Camara REAL del Juego (la verdadera cámara, la de A.R. de Vuforia, motor de X.R.).
    /// </summary>
    [Tooltip("Camara REAL del Juego (la verdadera cámara, la de A.R. de Vuforia, motor de X.R.).")]
    public Camera _miCamaraRealDeLaApp;

    #endregion Camara y Animaciones
    #endregion Variables de Animaciones


    #region Musica y Sonidos
    #region Musica
    #endregion Musica
    #region Sonidos

    // AUDIO VOICE-OVER:
    //
    /// <summary>
    /// Audio de VOICE-over que explica como jugar. Ejecutar antes de iniciar todo.
    /// </summary>
    [Tooltip("Audio de VOICE-over que explica como jugar.")]
    public AudioClip _miSonidoDeExplicacionComoJugar;


    //SFX:

    /// <summary>
    /// CANAL y Fuente del Audio: Animaciones de ACIERTOS y FALLOS
    /// </summary>
    //[Tooltip("CANAL y Fuente del Audio: Animaciones de ACIERTOS y FALLOS")]
    [HideInInspector]
    public AudioSource _miAudioSourceSonidoDeAciertosYFracasosTriviaPreguntas;


    // Aciertos:

    /// <summary>
    /// Lista de Sonidos Aciertos.
    /// </summary>
    [Tooltip("Lista de Sonidos Aciertos.")]
    public AudioClip[] _miListaDeSonidosDeAnimacionesAciertos;

    /// <summary>
    /// Longitud de: Lista de Sonidos Aciertos.
    /// </summary>
    [Tooltip("Longitud de: Lista de Sonidos Aciertos.")]
    public int _miLongitudListaDeSonidosDeAnimacionesAciertos = 0;


    ///// <summary>
    ///// Sonido de Animacion Acierto: 1 Muy Bien!
    ///// </summary>
    //[Tooltip("Sonido de Animacion Acierto: 1 Muy Bien!")]
    //public AudioClip _miSonidoDeAnimacionAcierto1_MuyBien;

    ///// <summary>
    ///// Sonido de Animacion Acierto: 2 Siii!
    ///// </summary>
    //[Tooltip("Sonido de Animacion Acierto: 2 Siii!")]
    //public AudioClip _miSonidoDeAnimacionAcierto2_Siii;


    // Fallos:

    /// <summary>
    /// Lista de Sonidos Fallos.
    /// </summary>
    [Tooltip("Lista de Sonidos Fallos.")]
    public AudioClip[] _miListaDeSonidosDeAnimacionesFallos;


    /// <summary>
    /// Longitud de: Lista de Sonidos Fallos.
    /// </summary>
    [Tooltip("Longitud de: Lista de Sonidos Fallos.")]
    public int _miLongitudListaDeSonidosDeAnimacionesFallos = 0;

    ///// <summary>
    ///// Sonido de Animacion Fallo: 1 TrataOtraVez1!
    ///// </summary>
    //[Tooltip("Sonido de Animacion Fallo: 1 TrataOtraVez1!")]
    //public AudioClip _miSonidoDeAnimacionFallo1_TrataOtraVez1;

    ///// <summary>
    ///// Sonido de Animacion Fallo: 2 VamosTuPuedes1!
    ///// </summary>
    //[Tooltip("Sonido de Animacion Fallo: 2 VamosTuPuedes1!")]
    //public AudioClip _miSonidoDeAnimacionFallo2_VamosTuPuedes1;


    #endregion Sonidos
    #endregion Musica y Sonidos


    #region Utility y Miscelaneos
    #region Garbage Collection

    /// <summary>
    /// GarbageCollectionManager
    /// Mi Clase que es un CONTENEDOR DE MÉTODOS para la Limpieza de la Basura (Garbage Collection), generada por VUFORIA Pricipalmente (el NameSpace VuforiaBehaviour genera muchos GC.Alloc).
    /// No es del Tipo MonoBehaviour, es decir, nada de: UPDATE, AWAKE, GetComponent... todo eso se hará en el GameManager, y si hace falta: se suscribirá a esos métodos al GameManager 
    /// TODO (aún tengo que Googlear cómo hacer eso).
    /// </summary>
    [Tooltip("GarbageCollectionManager \nMi Clase que es un CONTENEDOR DE MÉTODOS para la Limpieza de la Basura (Garbage Collection), generada por VUFORIA Pricipalmente (el NameSpace VuforiaBehaviour genera muchos GC.Alloc). \nNo es del Tipo MonoBehaviour, es decir, nada de: UPDATE, AWAKE, GetComponent... todo eso se hará en el GameManager, \ny si hace falta: se suscribirá a esos métodos al GameManager (aún tengo que Googlear cómo hacer eso).")]
    public static GarbageCollectionManager _miGarbageCollectionManager;

    /// <summary>
    /// (readonly) Heap de Memoria o Garbage / Basura actual. Recomendado: Limpia si es mayor a 27 MB (27.000.000 KB)
    /// </summary>
    [Tooltip("(readonly) Heap de Memoria o Garbage / Basura actual. Recomendado: Limpia si es mayor a 27 MB (27.000.000 KB)")]
    public long _miMemoriaHeapGarbageActual = 0;


    /// <summary>
    /// Variable que dice si el JUEGO esta en un MOMENTO en que es posible activar el GC.Collect() para Limpiar la Garbage de la Memoria: sin afectar negativamente el PERFORMANCE mucho...
    /// </summary>
    public bool _puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance = false;


    /// <summary>
    /// Constante que define el Tamano mínimo del HEAP PERMITIDO antes de ejecutar una limpieza, i.e. llamada a GC.Collect()
    /// </summary>
    public const long _TAMANO_HEAP_GARBAGE_MINIMO_BYTES = 27000000; //50000000;


    /// <summary>
    /// Constante que define el Tamano máximo (ESTADO DE EMERGENCIA!) del HEAP PERMITIDO antes de ejecutar una limpieza, i.e. llamada a GC.Collect()
    /// </summary>
    public const long _TAMANO_HEAP_GARBAGE_MAXIMO_EMERGENCIA_BYTES = 43000000; //50000000;

    /// <summary>
    /// Variable que cuenta el tiempo transcurrido entre invocaciones a: System.GC.Collect.
    /// </summary>
    [Tooltip("Variable que cuenta el tiempo transcurrido entre invocaciones a: System.GC.Collect.")]
    public float _miTiempoParaInvocarGCCollect = 0.0f;


    /// <summary>
    /// CONSTANTE DE TIEMPO MÍNIMA para definir CUÁNDO se Realizará un GC.Collect()
    /// </summary>
    [Tooltip("CONSTANTE DE TIEMPO MÍNIMA para definir CUÁNDO se Realizará un GC.Collect()")]
    public const float _CONSTANTE_TIEMPO_MINIMA_N_SEGUNDOS_PUEDE_INVOCAR_GC_COLLECT = 96.0f; // Basado en Proporcion aurea: 4.8f;   // 12.0f;   // 10.0f

    /// <summary>
    /// CONSTANTE DE TIEMPO MÁXIMA para definir CADA CUÁNTO se Realizará un GC.Collect()
    /// </summary>
    [Tooltip("CONSTANTE DE TIEMPO MÁXIMA para definir CADA CUÁNTO se Realizará un GC.Collect(), INCLUSO FORZADO COMO EMERGENCIA")]
    public const float _CONSTANTE_TIEMPO_MAXIMO_EMERGENCIA_N_SEGUNDOS_INVOCAR_GC_COLLECT = 150.45f;  //96.0f;   // 150.45f para 43.69 MB;    // 180.0f;

    /// <summary>
    /// CONSTANTE DE TIEMPO MÍNIMA para POSTPONER la LIMPIEZA DE GARBAGE HEAP (i.e.: GC.Collect()), cuando se encuentra en un MAL MOMENTO (de PERFORMANCE CRÍTICO).
    /// </summary>
    [Tooltip("CONSTANTE DE TIEMPO MÍNIMA para POSTPONER la LIMPIEZA DE GARBAGE HEAP (i.e.: GC.Collect()), cuando se encuentra en un MAL MOMENTO (de PERFORMANCE CRÍTICO).")]
    public const float _CONSTANTE_TIEMPO_MINIMA_N_SEGUNDOS_POSPONER_UN_POCO_INVOCACION_A_GC_COLLECT = _CONSTANTE_TIEMPO_MINIMA_N_SEGUNDOS_PUEDE_INVOCAR_GC_COLLECT - 5.41f;  //5.41f; // Basado en Proporcion aurea: // 5.41f; // 8.75f;  // 14.0f

    #endregion Garbage Collection


    #region Strings Optimization

    /// <summary>
    /// Variable de NUMEROS para usar: no generar GARBAGE COLLECTION, al realizar una conversion estilo Int32 'ToString()'...
    /// ..Cada NUMERO equivale a CASILLA. Empieza desde Cero; termina en 20
    /// </summary>
    [Tooltip("Variable de NUMEROS para usar: no generar GARBAGE COLLECTION, al realizar una conversion estilo Int32 'ToString()'...\n..Cada NUMERO equivale a CASILLA. Empieza desde Cero; termina en 20")]
    private static readonly string[] _NUMEROS_STRING_LIMITE_20 = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" };

    /// <summary>
    /// Longitud MÁXIMA a usar de: ""_NUMEROS_STRING_LIMITE_20"" (i.e.: Variable de NUMEROS para usar: no generar GARBAGE COLLECTION, al realizar una conversion estilo Int32 'ToString()'... \n..Cada NUMERO equivale a CASILLA. Empieza desde Cero; termina en 20
    /// </summary>
    [Tooltip("Longitud MÁXIMA a usar de: ''_NUMEROS_STRING_LIMITE_20'' (i.e.: Variable de NUMEROS para usar: no generar GARBAGE COLLECTION, al realizar una conversion estilo Int32 'ToString()'...\n..Cada NUMERO equivale a CASILLA. Empieza desde Cero; termina en 20.)")]
    private static readonly int _LENGTH_DE_NUMEROS_STRING_LIMITE_20 = 20;

    #endregion Strings Optimization


    #region DebugLogs 

    /// <summary>
    /// Quiere que los //DEBUG.LOG(), .WARNING() Y .ERROR() se generen y vean en el LogCat() de Android, o su Dispositivo?
    /// </summary>
    [Tooltip("Quiere que los //DEBUG.LOG(), .WARNING() Y .ERROR() se generen y vean en el LogCat() de Android, o su Dispositivo?")]
    [SerializeField]
    private bool _verDebugLogsWarningsErrors = false;

    #endregion DebugLogs

    #endregion Utility y Miscelaneos

    #endregion Atributos



    #region Awake y Start

    /// <summary>
    /// Awake this instance.
    /// </summary>
    void Awake()
    {
        // Initialize pointer to this static instance, for that all GameObjects can access It:
        //
        if (gm == null)
        {
            gm = gameObject.GetComponent<GameManager>();

        }//End if

        // Camara del Juego:
        //
        if (this._miCamaraRealDeLaApp == null)
        {
            // if ""this._miCamara"" is missing
            ////////Debug.LogWarning("El Componente 'this._miCamara' esta faltando dentro de este GameObject. Agregando uno.");

            // Agregando el componente dinamicamente: 'this._miCamara'.
            //
            this._miCamaraRealDeLaApp = Camera.main;

        }//End if
        //
        // Hero of the Game:
        //
        if (this._miVideoPlayer == null)
        {

            // El VIDEO: debe estar atacheado a este GameObject, o habrá ERROR.
            //
            this._miVideoPlayer = this.gameObject.GetComponent<VideoPlayer>();

            // Validar:
            //
            if (this._miVideoPlayer == null)
            {

                // El VIDEO: debe estar atacheado a este GameObject, o habrá ERROR.
                // Lanza el error. No Continuar:
                //
                Debug.LogError("El Componente '_miVideoPlayer':\n*** Esta faltando (porque no fue agregado dentro del INSPECTOR en clase 'GameManager.cs') dentro de este GameObject.\n...Y NO PODEMOS ENCONTRARLO.\n....Se deberá detener la ejecución");

            }//End if

        }//End if

        // Fuegos Artificiales, celebracion:
        //
        if (this._miGameObjectFuegosArtificiales == null)
        {

            // Lanza el error. No Continuar:
            //
            Debug.LogError("El Componente '_miGameObjectFuegosArtificiales':\n*** Esta faltando (porque no fue agregado dentro del INSPECTOR en clase 'GameManager.cs') dentro de este GameObject.\n...Y NO PODEMOS ENCONTRARLO.\n....Se deberá detener la ejecución");

        }//End if
        else
        {

            // Disable:
            //
            this._miGameObjectFuegosArtificiales.SetActive( false );

        }//End else
        //
        // Hero of the Game:
        //
        if (this._miScriptKaraokeGameObjectPlayer == null)
        {

            // El Karaoke representa al "Player".
            //
            this._miScriptKaraokeGameObjectPlayer = this.gameObject.GetComponent<Karaoke>();

        }//End if
        //
        // Timer o Cronometros de cada PREGUNTA en pantalla:
        //
        if (this._miScriptConteoDeTiempo == null)
        {

            // Agregar this._miScriptConteoDeTiempo
            //
            this._miScriptConteoDeTiempo = this.gameObject.AddComponent<ConteoDeTiempo>();

        }//End if

        #region Ini de GUI
        #region GUI CANVAS de TRIVIAS

        // Ini de  GUI
        //
        // Obtener el COMPONENTE CANVAS:
        //
        if (this._miGUITrivia1GUIComponenteCanvasEnGameObjectCanvas == null)
        {

            // Obtener el COMPONENTE CANVAS:
            //
            this._miGUITrivia1GUIComponenteCanvasEnGameObjectCanvas = GameObject.FindWithTag(_MI_TRIVIA_1_GUI_CANVAS_TAG).GetComponent<Canvas>();

        }//end if

        if (this._miGUITrivia2GUIComponenteCanvasEnGameObjectCanvas == null)
        {

            // Obtener el COMPONENTE CANVAS:
            //
            this._miGUITrivia2GUIComponenteCanvasEnGameObjectCanvas = GameObject.FindWithTag(_MI_TRIVIA_2_GUI_CANVAS_TAG).GetComponent<Canvas>();

        }//end if
        if (this._miGUITrivia3GUIComponenteCanvasEnGameObjectCanvas == null)
        {

            // Obtener el COMPONENTE CANVAS:
            //
            this._miGUITrivia3GUIComponenteCanvasEnGameObjectCanvas = GameObject.FindWithTag(_MI_TRIVIA_3_GUI_CANVAS_TAG).GetComponent<Canvas>();

        }//end if
        //
        // Validación:
        //
        if ((this._miGUITrivia1GUIComponenteCanvasEnGameObjectCanvas == null) || (this._miGUITrivia2GUIComponenteCanvasEnGameObjectCanvas == null) || (this._miGUITrivia3GUIComponenteCanvasEnGameObjectCanvas == null))
        {

            // Lanza el error. No Continuar:
            //
            Debug.LogError("El Componente '_miGUITrivia1GUIComponenteCanvasEnGameObjectCanvas', 2 o 3:\n*** Esta faltando (porque no fue agregado dentro del INSPECTOR en clase 'GameManager.cs') dentro de este GameObject.\n...Y NO PODEMOS ENCONTRARLO CON EL TAG = '_MI_TRIVIA_1_GUI_CANVAS_TAG', 2 ó 3.\n....Se deberá detener la ejecución");

        }//eND IF
        else
        {
            // Todo Válido: Agregar a un Array[] para fácil manejo:
            //
            this._miListaDeGUITriviasGUIComponenteCanvasEnGameObjectCanvas[0] = this._miGUITrivia1GUIComponenteCanvasEnGameObjectCanvas;
            this._miListaDeGUITriviasGUIComponenteCanvasEnGameObjectCanvas[1] = this._miGUITrivia2GUIComponenteCanvasEnGameObjectCanvas;
            this._miListaDeGUITriviasGUIComponenteCanvasEnGameObjectCanvas[2] = this._miGUITrivia3GUIComponenteCanvasEnGameObjectCanvas;

        }//End else del if

        #endregion GUI CANVAS de TRIVIAS


        #region GUI 'ROUND X' - UI TEXT
        #endregion GUI 'ROUND X' - UI TEXT
        #region GUI Barra de Goles - UI TEXT
        #endregion GUI Barra de Goles - UI TEXT  
        #endregion Ini de GUI



        #region Garbage Collection

        // Initialize pointer to this static instance, for that all GameObjects can access It:
        //
        _miGarbageCollectionManager = new GarbageCollectionManager();

        // No está activada la Limpieza cada N-segundos: activar para verificar cada n-segundos
        //
        this._puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance = false;
        //
        // Basura en HEAP MEMORIA actual: Inicialización.
        //
        this._miMemoriaHeapGarbageActual = 0;
        //
        // Poner en cero el TIMER GENERAL DE GARBAGE para LIMPIAR.
        //
        this._miTiempoParaInvocarGCCollect = 0.0f;

        #endregion Garbage Collection


        #region Configuracion de App

        // Configurar la App, para óptimo funcionamiento:
        //
        this.ConfigureAppInitialParameters();

        #endregion Configuracion de App




        #region Camara y Animaciones
        #region Animacion de Personajes
        #endregion Animacion de Personajes
        #endregion Camara y Animaciones


        #region Sonidos y Musica

        // Obtener 'AudiosSources' en el hijo de la Camara (ver 'MainCamera' en la Jerarquía del UNITY3D):
        //
        AudioSource[] miListaDeAudiosSources = this._miCamaraRealDeLaApp.GetComponentsInChildren<AudioSource>();

        // Asignar c/'canal de audio' a su respectiva variable:
        // 1- Aciertos / Fallos:
        //
        this._miAudioSourceSonidoDeAciertosYFracasosTriviaPreguntas = miListaDeAudiosSources[0];

        // Calcular Longitud de array de Sonidos: Aciertos y Fallos:
        //
        this._miLongitudListaDeSonidosDeAnimacionesAciertos = this._miListaDeSonidosDeAnimacionesAciertos.Length;
        this._miLongitudListaDeSonidosDeAnimacionesFallos = this._miListaDeSonidosDeAnimacionesFallos.Length;

        #endregion Sonidos y Musica


        #region Efectos Visuales
        #endregion Efectos Visuales


        #region Corrutinas - Optimizacion
        #endregion Corrutinas - Optimizacion

    }//End Method Awake



    /// <summary>
    /// Configures this App's initial parameters.
    /// </summary>
    private void ConfigureAppInitialParameters()
    {

        #region Configuration Settings del Dispositivo

        // Celular NO se DUERMA, ni se apague la pantalla durante el juego por no tocar la pantalla un cierto tiempo:
        //
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

        #endregion Configuration Settings del Dispositivo


        #region Configuracion del Juego

        // Inicializacion:

        // Variables finales a inicializar dentro del UPDATE, como primer y único paso una sola vez 
        //...(ésta es la BANDERA / FLAG que se encargará de asegurar que se ejecute 1 vez):
        //
        this._gameStateWhenPlaying = _GAME_STATES_WHEN_PLAYING.InicializacionFinalVariables;


        #region Debug.Logs

        // Apagar todos los LOGS de PLUGINS + mi propio código:
        //
#if !DEVELOPMENT_BUILD && !UNITY_EDITOR

        // Release BUILD o PLAYMODE (UNITY_EDITOR) de prueba:
        //
        //Debug.Log("I will NOT print this in a DEVELOPMENT_BUILD.\nNot in PlayMode of Unity3D, either");
        //
        //////Debug.Log("I will NOT print this in a DEVELOPMENT_BUILD. Maybe in the UNITY EDITOR YEAH");

        // Apagar OBLIGADO todos los LOGS de PLUGINS + mi propio código:
        //
        this._verDebugLogsWarningsErrors = false;
        //
        //Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);    // Se puede setear para cada tipo: LogType.Assert, LogType.Error, etc
#endif


        // Apagar o Encender: todos los LOGS de PLUGINS + mi propio código:
        //
        Debug.unityLogger.logEnabled = this._verDebugLogsWarningsErrors;     //false;
        //
        //Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);    // Se puede setear para cada tipo: LogType.Assert, LogType.Error, etc

        #endregion Debug.Logs


        #region Render - Graphics

        // 1- Resolver el bug del ""Depth Render"" Shadows, una vez que se activa la opción en la CÁMARA: 
        //...(nunca solucionado por UNITY3D), sí está solucionado en el nuevo GRAPHICS RENDER PIPELINE DEL 2018.3.
        // Explicación: Enabling 'DepthNormals' on the Camera, causes Unity to not batch any draw-call during UpdateDepthNormalsTexture 
        //...in Forward Rendering. Batching does work in DeferredRendering though. I submitted a bug-report a while ago for this issue: 
        //...(Case 924489) Draw-call batching not working during UpdateDepthNormalsTexture

        // -> https://forum.unity.com/threads/poor-performance-of-updatedepthtexture-why-is-it-even-needed.197455/
        //    Camera.main.depthTextureMode = DepthTextureMode.None;
        //
        this._miCamaraRealDeLaApp.depthTextureMode = DepthTextureMode.None;


        // 2- VSYNC  y  3- Setear una correcta RESOLUCION DE PANTALLA (i.e.: que permita ahorrar RAM, trabajo de GPU y  trabajo de CPU...),
        // ...acorde a variables pasadaas como parámetros de entrada a esta clase (GameManager.cs).
        //
        // Sólo si la PLATAFORMA (OS) es de un "LOW - END DEVICE": ANDROID, iOS o TV:
        //
        if ((Application.isMobilePlatform) || (Application.platform == RuntimePlatform.Android) || (Application.platform == RuntimePlatform.IPhonePlayer) /*|| (Application.platform == RuntimePlatform.SamsungTVPlayer)*/ || (Application.platform == RuntimePlatform.WSAPlayerARM) || (Application.platform == RuntimePlatform.WSAPlayerX86) || (Application.platform == RuntimePlatform.WSAPlayerX64) || (Application.platform == RuntimePlatform.WindowsEditor) || (Application.platform == RuntimePlatform.LinuxEditor) || (Application.platform == RuntimePlatform.OSXEditor))
        {

            // 2- VSYNC: The number of VSyncs that should pass between each frame. 
            // .. Use 'Don't Sync' (0) to not wait for VSync. Value must be 0, 1 (Dysplay - Monitor o Pantalla default: 60 Hz <=> 60 FPS), 2 (la mitad, 30 Hz / FPS), 3, or 4.
            //
            // Sync framerate to ‘don’t’ sync’ refresh rate
            //
            ///// NUEVO CÓDIGO: No haré un seteo del SYNC por esta via (debido a que VUFORIA A.R.: LO HACE, vSYNC a 30 FPS capeado..., no voy a interferir con eso), solamente a través de las opciones del Editor:  setearé No vSync (lo cual será igualmente alterado con los Scripts de inicialización de Vuforia):
            //
            QualitySettings.vSyncCount = 0;   //2;     // 2 <=> Este Valor lo capea a 30 FPS
            //
            ///// VIEJO CÓDIGO: QualitySettings.vSyncCount = 0; // No sincronizar nada. Libertad.


            // 3-   Setear una CALIDA "MEDIA" FIJADA POR MI:
            //
            this.SetearConfiguracionGraficaGlobalSegunPoderDeDispositivo(_MI_FPS_CONSTANTE_MOBILE /* FPS FIJADO para estos sistemas */, this._miCalidadDeQualitySettings /* Se HEREDARÁ del INSPECTOR */ /*_CALIDAD_DE_QUALITY_SETTINGS.MEDIUM */  /* .MEDIUM = 2 */ );


        }//End if (Application.platform == RuntimePlatform.Android)
        //
        else    // Hablamos de un MID - END y HIGH - END device: Windows, Linux, Mac PC, o CONSOLAS DE JUEGOS (PS, PS2, PS3, PS4, Nintendo Switch, etc...)
        {

            // 2- VSYNC: The number of VSyncs that should pass between each frame. 
            // .. Use 'Don't Sync' (0) to not wait for VSync. Value must be 0, 1 (Dysplay - Monitor o Pantalla default: 60 Hz <=> 60 FPS), 2 (la mitad, 30 Hz / FPS), 3, or 4.
            //
            // Sync framerate to ‘don’t’ sync’ refresh rate
            //
            ///// NUEVO CÓDIGO: No haré un seteo del SYNC por esta via (debido a que VUFORIA A.R.: LO HACE, vSYNC a 30 FPS capeado..., no voy a interferir con eso), solamente a través de las opciones del Editor:  setearé No vSync (lo cual será igualmente alterado con los Scripts de inicialización de Vuforia):
            //
            QualitySettings.vSyncCount = 1;     // Este Valor lo capea a 60 FPS
            //
            ///// VIEJO CÓDIGO: QualitySettings.vSyncCount = 0; // No sincronizar nada. Libertad.


            // 3-   Setear una CALIDA MEDIA hacia: "ALTA" FIJADA POR MI:
            //
            this.SetearConfiguracionGraficaGlobalSegunPoderDeDispositivo(_MI_FPS_CONSTANTE_STANDALONE /* FPS FIJADO para estos sistemas */, _CALIDAD_DE_QUALITY_SETTINGS.NON_INITIALIZED_INHERIT_FROM_ABOVE_METHODS /* Se HEREDARÁ de un MENÚ PRINCIPAL o del INSPECTOR */ );


        }//End Else del if (Application.platform == RuntimePlatform.Android || (Application.platform == RuntimePlatform.IPhonePlayer) || (Application.platform == RuntimePlatform.SamsungTVPlayer) || (Application.platform == RuntimePlatform.WSAPlayerARM) || (Application.platform == RuntimePlatform.WSAPlayerX86) || (Application.platform == RuntimePlatform.WSAPlayerX64) )


        #endregion Render - Graphics

        #endregion Configuracion del Juego


        #region Physics 2D - Fisica 2D

        // Apagar la Física 2D y 3D:
        //
        Physics.autoSimulation = false;
        //
        // NOTA: Poner este de abajo ('Physics2D.autoSimulation') en 'TRUE':     Si deseo usar RIGIDBODIES 2D y COLLIDERS 2D.
        //
        Physics2D.autoSimulation = false;

        #endregion Physics 2D - Fisica 2D


        #region Camera Settings

        // Apagar Occlusion Culling
        //
        if (this._miCamaraRealDeLaApp.useOcclusionCulling)
        {

            this._miCamaraRealDeLaApp.useOcclusionCulling = false;

        }//End if ( this._miCamara.useOcclusionCulling )

        #endregion Camera Settings

    }//End Method ConfigurarParametrosApp()



    /// <summary>
    /// Start this instance. Executes itself once. It executes when this Script is Enabled.
    /// </summary>
    void Start()
    {
        #region Garbage Collection

        // Inicializa un HEAP GRANDE de basura:
        //
        /////_miGarbageCollectionManager.InicializarHeapAllocGrande();


        #endregion Garbage Collection


        #region Configuracion del Juego

        //  DIFICULTAD
        //
        ///// No necesario en este demo: this.InicializarDificultadDelJuego();

        #endregion

    }//End Method Start


    #endregion Awake y Start


    #region Update

    /// <summary>
    /// Update this instance, it is executed once in each frame.
    /// </summary>
    void Update()
    {

        /////Profiler.BeginSample("ddd GameManager.Update() General");

        #region Game State / Fases de Juego

        switch (_mainGameState)
        {

            case _GAME_STATES.Playing:

                // FASE 0 (solo se ejecutará una vez):  Inicializar variables después que las de TODOS los SCRIPTS lo han hecho:
                //
                switch (this._gameStateWhenPlaying)
                {

                    case _GAME_STATES_WHEN_PLAYING.InicializacionFinalVariables:

                        #region Configuracion del Juego

                        // Habilitar Objetos que aparecen al PRINCIPIO del Juego (enable):
                        //
                        /////this._miMicrophoneInputDelBalon._miConductaBalon.ActivarYmostrar();


                        // Garbage Collection: Aviso que en este ESTADO sí puedo Limpiar la GARBAGE:
                        //
                        this._puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance = true;

                        #endregion Configuracion del Juego


                        /////INICIO DE:///BORRAR O COMENTAR cuando haga BUILD-DEPLOY FINAL:
                        ////
                        //Debug.Log("GameManager.cs -> Update()\n->\nRESOLUCION DE PANTALLA APLICADA AL FINAL: Screen.currentResolution = " + Screen.currentResolution);

                        //// Resoluciones existentes:
                        ////
                        //int longRes = Screen.resolutions.Length;
                        ////
                        //Debug.Log("GameManager.cs -> RESOLUCIONES DISPONIBLES para este OS:\n->\n");
                        ////
                        //for (int i = 0; i < longRes; i++)
                        //{

                        //    ///Debug.Log(i + " )-- " + Screen.resolutions[ i ].ToString() );

                        //}//End for

                        ////////BORRAR DESPUES O COMENTARRRRR:::::::://///////////////
                        ////
                        //Debug.Log("QUALITY SETTINGS FIJADOS (mi variable): this._miCalidadDeQualitySettings = " + this._miCalidadDeQualitySettings);
                        //Debug.Log("QUALITY SETTINGS FIJADOS: QualitySettings.GetQualityLevel() = " + QualitySettings.GetQualityLevel());
                        //Debug.Log("QUALITY SETTINGS FIJADOS: QualitySettings.names[ QualitySettings.GetQualityLevel() ] = " + QualitySettings.names[QualitySettings.GetQualityLevel()]);
                        //Debug.Log("FPS fijados: = " + Application.targetFrameRate);
                        ////
                        /////FIN DE:///BORRAR DESPUES O COMENTARRRRR:::::::://///////////////


                        // Fin de esta ETAPA INICIALIZATORIA:
                        //
                        // Marcar paso a siguiente FASE 1: Preparando Variables para Empezar a Chutar (RE-INICIALIZACION)
                        //
                        this._gameStateWhenPlaying = _GAME_STATES_WHEN_PLAYING.AntesDeIniciarCancion;

                        break;


                    // FASE 1:  Inicializar (o REINICIALIZAR) Variables para poder Cantar de Nuevo.
                    //
                    case _GAME_STATES_WHEN_PLAYING.AntesDeIniciarCancion:

                        // 0- Activar el Garbage Collector (si estaba apagado) y hacer una LIMPIEZA INICIAL.. luego apagar.
                        //
                        // 1- ACTIVAR Controles GUI:
                        //   1.1- ACTIVAR GUI Pregunta 1.
                        //   1.2- DES-Activar Todo lo que vaya a usar DESPUES, no aún.
                        //
                        // 2- Activar movimientos (update) de personajes del Juego:
                        //	 .- Ubicar en su lugar a las Imágenes y Personajes.
                        //   .- Setear la Posicion de la Cámara.
                        //
                        // 3- Preparar otras variables para esta FASE e: Iniciar Canción.


                        // Inicio:
                        //
                        // 0- Activar el Garbage Collector (si estaba apagado) y hacer una LIMPIEZA INICIAL.. luego apagar.
                        //
                        _miGarbageCollectionManager.EnableGC_CleanGC();
                        //
                        // Garbage Collection: Aviso que en este ESTADO sí puedo Limpiar la GARBAGE:
                        //
                        this._puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance = true;


                        // Preparando terreno: para FASE SIGUIENTE:
                        //
                        // Play Video - Canción Karaoke!
                        //
                        if (! this._miVideoPlayer.isPlaying)
                        {

                            // Ejecutar, iniciar video
                            //
                            this._miVideoPlayer.Play();

                            // Iniciar Letras de Karaoke, aparte y 'en paralelo':
                            //
                            this._miScriptKaraokeGameObjectPlayer.StartSubtitle();

                            // Iniciar (O INICIALIZAR) cualquier otro Proceso necesario para INICIAR el Juego:
                            //
                            // Iniciar el Audio que explica 'como jugar?':
                            //
                            // 1-   Sonido:  Audio que explica 'como jugar?':
                            //
                            this._miAudioSourceSonidoDeAciertosYFracasosTriviaPreguntas.PlayOneShot( this._miSonidoDeExplicacionComoJugar );

                        }//End if
                        


                        // Garbage Collection: Aviso que en este ESTADO NO puedo Limpiar la GARBAGE:
                        //
                        this._puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance = false;


                        // Marcar paso a siguiente FASE 2: ANIMACION INICIAL QUE DICE:   RONDA 1 (ó X).
                        //
                        this._gameStateWhenPlaying = _GAME_STATES_WHEN_PLAYING.DuranteLaCancion;


                        // ZZ- Des-Activar el Garbage Collector (si estaba Encendido).
                        //
                        _miGarbageCollectionManager.DisableGC();
                        //
                        // Actualizar el Timer de Limpieza, a CERO:
                        //
                        this._miTiempoParaInvocarGCCollect = 0.0f;

                        break;


                    // FASE 2: Canción en Progreso.
                    //
                    case _GAME_STATES_WHEN_PLAYING.DuranteLaCancion:

                        //// Garbage Collection: Aviso que en este ESTADO NO puedo Limpiar la GARBAGE:
                        ////
                        //this._puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance = false;


                        // JUEGO:
                        // Preguntar por qqué Parte de la Canción va: Así hará aparecer los Objetos en Pantalla adecuados (i.e.: Las IMÁGENES DE TRIVIAS)
                        //
                        if (this._miScriptKaraokeGameObjectPlayer._estaPendienteUnCambioDeFraseOTrivia)
                        {

                            // Pendiente un Cambio de Frase a una Nueva TRIVIA: ENCENDER POP-UP correspondiente:
                            //
                            this._miListaDeGUITriviasGUIComponenteCanvasEnGameObjectCanvas[ this._miScriptKaraokeGameObjectPlayer._miParteDeLaCancionActual ].enabled = true;
                            //
                            // Encender TIMER o CRONOMETRO:
                            //                            
                            this._miScriptConteoDeTiempo.IniciarConteo(true, _MIS_TIEMPOS_MAXIMO_CRONOMETRO_TODAS_LAS_TRIVIAS[this._miScriptKaraokeGameObjectPlayer._miParteDeLaCancionActual] );


                            // Apagar o esconder el POP-UP anterior, si lo hay
                            //
                            if ( this._miScriptKaraokeGameObjectPlayer._miParteDeLaCancionActual > 0)
                            {

                                // Deshabilitar visibilidad:
                                //
                                this._miListaDeGUITriviasGUIComponenteCanvasEnGameObjectCanvas[this._miScriptKaraokeGameObjectPlayer._miParteDeLaCancionActual - 1].enabled = false;

                                // Disable:
                                //
                                this._miGameObjectFuegosArtificiales.SetActive(false);

                            }//End if ( this._miScriptKaraokeGameObjectPlayer...


                            // Ya no está 'PENDIENTE' ningun cambio de Frase del Karaoke:
                            //
                            this._miScriptKaraokeGameObjectPlayer._estaPendienteUnCambioDeFraseOTrivia = false;

                        }//End if
                        else
                        //
                        // Verificar si ya el TIMER O CRONÓMETRO se accabo para el caso de la FRASE ACTUAL:
                        //
                        if ( this._miScriptConteoDeTiempo._estadoConteoDelTiempo == ConteoDeTiempo._ESTADO_CRONOMETRO.ActivadoYaSeCumplioTiempo )
                        {

                            // Esconder las imágenes de la Trivia:
                            // Deshabilitar visibilidad:
                            //
                            this._miListaDeGUITriviasGUIComponenteCanvasEnGameObjectCanvas[ this._miScriptKaraokeGameObjectPlayer._miParteDeLaCancionActual ].enabled = false;

                            // Disable:
                            //
                            this._miGameObjectFuegosArtificiales.SetActive(false);


                            // Verificar si se acabó la canción (o al menos la parte subtitulada): EN ese caso: Permitir la Recolección de Basura.
                            //
                            if (this._miScriptKaraokeGameObjectPlayer._yaConsiguioFrase3)   // NOTA, OJO: EN ESTE DEMO se hizo hasta FRASE 3, expandir a FaseFinal la variable Booleana usada acá para verificar sin BUGS!
                            {

                                // Marcar el INICIO de la siguiente FASE:
                                //
                                this._gameStateWhenPlaying = _GAME_STATES_WHEN_PLAYING.FinalizadaLaLetraDeLaCancion;

                            }//End if ( this._miScriptKaraokeGameObjectPlayer...

                        }//End if ( this._miScriptConteoDeTiempo...

                        break;


                    case _GAME_STATES_WHEN_PLAYING.FinalizadaLaLetraDeLaCancion:

                        #region Configuracion del Juego

                        // Garbage Collection: Aviso que en este ESTADO sí puedo Limpiar la GARBAGE:
                        //
                        this._puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance = true;

                        #endregion Configuracion del Juego

                        break;


                    default:

                        // Anunciar que se pasó por un Estado no considerado:
                        //
                        Debug.LogError("CRITICO OJO: Pasó por un caso no considerado en el 'Switch - Case' del Game Manager. No es cubierto por la variable de estados: 'this._gameStateWhenPlaying'");

                        break;

                }//End Switch 2 _GAME_STATES_WHEN_PLAYING
                //
                //////////////////End CASE estado PLAYING
                break;


            //// Ganó el Juego:
            ////
            //case _GAME_STATES.BeatLevel:


            //    // Sonido de CONGRATULATIONS: GANANDO O PERDIENDO:
            //    //
            //    if ((!this._scorePuntosOroP1 >= CIERTA_CANTIDAD_DE_META) && this._faltaReproducirSonidoAlFinalDeGanarOPerder)
            //    {

            //        // Play Sonido al Ganar / o Perder:
            //        //
            //        this.PlaySonidosGanarOPerderAlFinal();

            //        // Desplegar todas las animaciones (LETRAS 3D + CAMARA + RESULTADOS) de FIN DE JUEGO: WIN.
            //        //
            //        this.IniciarAnimacionDeFinDeJuego(true);


            //        // Setear el HECHO de haber GANADO:
            //        //
            //        this._miResultadoDelJuegoGaneOPerdi = true;
            //        //
            //        // Display la plantalla de GAME OVER, botones para seguir jugando:
            //        //
            //        this._mainGameState = _GAME_STATES.GameOver;

            //    }//End if

            //    break;


            //// Perdió el Juego:
            ////
            //case _GAME_STATES.Death:

            //    // Sonido de CONGRATULATIONS: GANANDO O PERDIENDO:
            //    //
            //    if ((!this._scorePuntosOroP1 < CIERTA_CANTIDAD_DE_META) && this._faltaReproducirSonidoAlFinalDeGanarOPerder)
            //    {

            //        // Play Sonido al Ganar / o Perder:
            //        //
            //        this.PlaySonidosGanarOPerderAlFinal();


            //        // Desplegar todas las animaciones (LETRAS 3D + CAMARA + RESULTADOS) de FIN DE JUEGO: LOSE.
            //        //
            //        this.IniciarAnimacionDeFinDeJuego(false);


            //        // Setear el HECHO de haber PERDIDO:
            //        //
            //        this._miResultadoDelJuegoGaneOPerdi = false;
            //        //
            //        // Display la plantalla de GAME OVER, botones para seguir jugando:
            //        //
            //        this._mainGameState = _GAME_STATES.GameOver;

            //    }//End if

            //    break;


            case _GAME_STATES.GameOver:


                break;

        }//End Switch-Case


        #endregion Game State / Fases de Juego


        #region Botones Fisicos Movil

        // Salir de la App, al presionar el boton BACK en Android, o ESCAPE (ESC) en PC:
        //
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Quitar la App:
            //
            Application.Quit();

        }//End if

        #endregion Botones Fisicos Movil



        #region Update  Garbage Collection

        // Mi GARBAGE COLLECTOR.
        //
        // Conteo del Tiempo ++ seg, DEL timer PARA LIMPIAR GC.COLLECT():
        //
        this._miTiempoParaInvocarGCCollect += Time.deltaTime;
        //
        // Guardar valor de MEMORY HEAP (GARBAGE):
        //
        this._miMemoriaHeapGarbageActual = System.GC.GetTotalMemory(false);
        //
        /////Debug.LogWarning("GAMEMANAGER GC : Memory used before collection (miGarbageActual KB): this._miMemoriaHeapGarbageActual = " + this._miMemoriaHeapGarbageActual);


        // CADA x (3?) minutos : Limpiar la GARBAGE. //No esto (demasiadas preguntas, no): verificar si la MEMORIA del Heap (basura) es mayor a 36 MB.
        //
        if ((this._miTiempoParaInvocarGCCollect > _CONSTANTE_TIEMPO_MINIMA_N_SEGUNDOS_PUEDE_INVOCAR_GC_COLLECT) && (this._miMemoriaHeapGarbageActual > _TAMANO_HEAP_GARBAGE_MINIMO_BYTES))
        {

            /////Debug.LogWarning("GAMEMANAGER GC : A punto de: EVALUANDO MOMENTOS... ");


            // Evaluando MOMENTOS 
            // ..para poder LIMPIAR: (BUENO, MAL MOMENTO o EMERGENCIA WHATEVER)...
            //
            if (this._puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance || (((_mainGameState == _GAME_STATES.Playing) && ((this._gameStateWhenPlaying ==
 _GAME_STATES_WHEN_PLAYING.InicializacionFinalVariables) || (this._gameStateWhenPlaying ==
 _GAME_STATES_WHEN_PLAYING.AntesDeIniciarCancion) || (this._gameStateWhenPlaying ==
 _GAME_STATES_WHEN_PLAYING.FinalizadaLaLetraDeLaCancion) || (this._gameStateWhenPlaying ==
 _GAME_STATES_WHEN_PLAYING.FinalizadaLaCancion))) || (_mainGameState == _GAME_STATES.GameOver)))
            {
                // Excelente Momento para LIMPIAR:
                //
                /////Debug.LogWarning("GAMEMANAGER GC : EVALUANDO MOMENTOS : Excelente Momento para LIMPIAR:  y  _miMemoriaHeapGarbageActual = " + _miMemoriaHeapGarbageActual);
                //
                // 1-Limpiar Basura de RAM:
                //
                _miGarbageCollectionManager.GCCollectApagandoGCautomatico();

                // 2- Poner TIMER EN CERO otra vez. (En Ambos casos sirve: a- LIMPIADO: VOLVER A EMPEZAR .. b- NO LIMPIADO: Posponer).
                //
                this._miTiempoParaInvocarGCCollect = 0.0f;


            }//End if ( this._puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance || ...
             //            
            else // 1- O no está en una FASE DE BAJO IMPACTO PERFORMANCE...
                 // 2- No es SUFICIENTEMENTE GRANDE el HEAP para limpiarlo: Posponer N-Segundos la Limpieza:
            {


                // Es una EMERGENCIA?  Puede ESPERAR?
                //
                if ((this._miMemoriaHeapGarbageActual > _TAMANO_HEAP_GARBAGE_MAXIMO_EMERGENCIA_BYTES) || (this._miTiempoParaInvocarGCCollect > _CONSTANTE_TIEMPO_MAXIMO_EMERGENCIA_N_SEGUNDOS_INVOCAR_GC_COLLECT))
                {

                    // Caso EXTREMO:  EMERGENCIA - URGENTE, LIMPIAR!
                    //
                    /////Debug.LogWarning("GAMEMANAGER GC : EVALUANDO MOMENTOS : Caso EXTREMO:  EMERGENCIA - URGENTE, LIMPIAR!");
                    //
                    // LIMPIAR!
                    //
                    _miGarbageCollectionManager.GCCollectApagandoGCautomatico();     // No usar esto, porque al dejar encendido el GARBAGE COL, Vuforia hace estragos: GCCollectDejandoEncendidoGCautomatico();    // Antes era: LIMPIAR Dejando encendido, porque quizá está en PAUSA; o lo requiere por haber entrado acá!

                    // 2- Poner TIMER EN CERO otra vez. (En Ambos casos sirve: a- LIMPIADO: VOLVER A EMPEZAR .. b- NO LIMPIADO: Posponer).
                    //
                    this._miTiempoParaInvocarGCCollect = 0.0f;


                }//End if (this._miMemoriaHeapGarbageActual < _TAMANO_HEAP_GARBAGE_MAXIMO_EMERGENCIA_BYTES)
                else
                {

                    // Caso MEDIO - URGENTE, aguantable aún..
                    //
                    /////Debug.LogWarning("GAMEMANAGER GC : EVALUANDO MOMENTOS : Caso MEDIO - URGENTE, aguantable aún..");
                    //
                    // Heap no CRITICO:   NO LIMPIAR aun, POSPONER unos segundos (dado: _CONSTANTE_TIEMPO_MINIMA_N_SEGUNDOS_POSPONER_UN_POCO_INVOCACION_A_GC_COLLECT), 
                    //...de esta manera no entrará dentro del IF PRINCIPAL del ALGORITMO, por unos pocos Segundos:
                    //
                    this._miTiempoParaInvocarGCCollect = _CONSTANTE_TIEMPO_MINIMA_N_SEGUNDOS_POSPONER_UN_POCO_INVOCACION_A_GC_COLLECT;

                }//End else if (this._miMemoriaHeapGarbageActual < ..

            }//End if (GC.GetTotalMemory(false) /* miGarbageActual */ > _TAMANO_HEAP_GARBAGE_MAXIMO_EMERGENCIA_BYTES)

        }//End if (this._estaActivadoLimpiezaCadaNSegundosManual && ( this._miTiempoParaInvocarGCCollect > _CONSTANTE_TIEMPO_N_SEGUNDOS_INVOCAR_GC_COLLECT ))


        #endregion Update  Garbage Collection

        /////Profiler.EndSample();

    }//End Metodo Update



    #endregion Update


    #region Metodos que no son de Base de Unity

    #region GUI
    #region GUI de MENU PAUSA / LET'S PLAY!
    /// <summary>
    /// Activar o Desactiva la Visibilidad del GUI Menu Pausa/Let's Play (Componente Canvas).
    /// </summary>
    ////////public void ActivarDesactivarCanvasGUIMenuPausaLetsPlayComponenteCanvas(bool activarOdesactivar)
    #endregion GUI de MENU PAUSA / LET'S PLAY!
    #endregion GUI


    #region Logica y Dinamica del Juego
    /// <summary>
    /// Chequea quien gana el juego.
    /// PRERREQUISITO:  Que ya se haya anotado el GOL y se actualizó el #NÚMERO TURNO del Jugador que acaba de Chutar.
    /// </summary>
    /////private void ChequearQuienGanaElJuego()
    #endregion Logica y Dinamica del Juego



    #region Musica y Sonidos

    #region Play Sound    
    #region Sonidos de Animaciones

    ///
    /// Accion que ocurrirá cuando el jugador elija una Respuesta CORRECTA
    ///
    public void ResponderConAciertoAPreguntaTrivia()
    {
        // 1-   Sonido
        // 2-   Animacion
        // 3-   +Score
        /////////////////
        //
        // 1-   Sonido:  Acierto.
        //
        this._miAudioSourceSonidoDeAciertosYFracasosTriviaPreguntas.PlayOneShot( this._miListaDeSonidosDeAnimacionesAciertos[Random.Range(0, this._miLongitudListaDeSonidosDeAnimacionesAciertos) ] );

        // 2-   Animacion
        //
        // Enable:
        //
        this._miGameObjectFuegosArtificiales.SetActive(true);


        // 3-   +Score
        //
        this._scorePuntosOroP1++;

        //zz- Apagar las Imagenes de Trivia
        //
        // Apagar o esconder el POP-UP anterior, si lo hay
        //
        if (this._miScriptKaraokeGameObjectPlayer._miParteDeLaCancionActual >= 0)
        {

            // Deshabilitar visibilidad:
            //
            this._miListaDeGUITriviasGUIComponenteCanvasEnGameObjectCanvas[ this._miScriptKaraokeGameObjectPlayer._miParteDeLaCancionActual ].enabled = false;

        }//End if ( this._miScriptKaraokeGameObjectPlayer...

    }//End Metdodo


    ///
    /// Accion que ocurrirá cuando el jugador elija una Respuesta INCORRECTA.
    ///
    public void ResponderConFalloAPreguntaTrivia()
    {

        // 1-   Sonido
        // 2-   Animacion
        // 3-   NO: +Score

        /////////////////
        //
        // 1-   Sonido:  Fallo.
        //
        this._miAudioSourceSonidoDeAciertosYFracasosTriviaPreguntas.PlayOneShot(this._miListaDeSonidosDeAnimacionesFallos[Random.Range(0, this._miLongitudListaDeSonidosDeAnimacionesFallos)]);

        // 2-   Animacion
        //
        // Enable:
        //
        ///// No, ninguna: this._miGameObjectFuegosArtificiales.SetActive(true);


        // 3-   +Score
        //
        /////No, no aumentar ni disminuir: this._scorePuntosOroP1++;

    }//End Metdodo


    #endregion Sonidos de Animaciones
    #endregion Play Sound
    #region Sonidos Corrutinas (Multiples)
    #endregion Sonidos Corrutinas (Multiples)
    /// <summary>
    /// Permite ejecutar un sonido, al Ganar o perder.
    /// Los sonidos son:
    /// [Si Ganas:   FELICIDADES!, seguido de un aliento o ánimo al jugador para seguir jugando en el futuro.]
    /// [Si pierdes: INTENTA DE NUEVO!, seguido de un aliento o ánimo al jugador para seguir jugando en el futuro.]
    /// </summary>
    //public void PlaySonidosGanarOPerderAlFinal()
    //{
    //}//End Metodo

    #endregion Musica y Sonidos


    #region Animaciones de Personajes.
    #endregion Animaciones de Personajes.


    #region Animacion de FIN de Juego: GANAR o PERDER
    #endregion Animacion de FIN de Juego: GANAR o PERDER


    #region Configuracion del Juego


    /// <summary>
    /// DIFICULTAD
    /// </summary>
    public void InicializarDificultadDelJuego()
    {
        // Dada la DIFICULTAD del Juego SELECCIONADA desde el MENÚ PRINCIPAL,
        // ..elegir la propia.
        //
        //...1- Acás e pueden setear el NÚMERO DE OPCIONES-RESPUESTA EN LA TRIVIA
        //...2- El Tiempo de EXPOSICIÓN, es decir: Cuantos segundos le darán de chance al Jugador para Ticar sobre ellos, (y anar los puntos, ganar).
        //...3- Quizá: Moverlos dentro de la Pantalla para hacer más dificil su CLick o  Tique...


        #region Variables dependientes de la Dificultad del Juego
        // Velocidad de las Físicas:
        #endregion Variables dependientes de la Dificultad del Juego

    }//end Metodo


    #region Configuracion Grafica - Pantalla

    #region Configuracion Grafica Global

    public void SetearConfiguracionGraficaGlobalSegunPoderDeDispositivo(int fpsFijado, _CALIDAD_DE_QUALITY_SETTINGS miCalidadDeQualitySettings)
    {
        // Make the game run at a good speed: 30 FPS for MOBILE and 60 FPS for PC.
        //
        Application.targetFrameRate = fpsFijado;
        //
        // Setear la CALIDAD DE LA APP en la variable (es un 'readonly'):
        //
        this._miCalidadDeQualitySettings = miCalidadDeQualitySettings;     // .MEDIUM = 2


        // Solo cambiar la Calidad si el valor es:      .NON_INITIALIZED_INHERIT_FROM_ABOVE_METHODS
        //
        if (miCalidadDeQualitySettings != _CALIDAD_DE_QUALITY_SETTINGS.NON_INITIALIZED_INHERIT_FROM_ABOVE_METHODS)
        {

            // Setear la CALIDAD DE LA APP:
            // Set 'Quality Settings' FIXED to: MEDIUM: 2,... for instance.
            //
            QualitySettings.SetQualityLevel((int)this._miCalidadDeQualitySettings);

        }//End if ( miCalidadDeQualitySettings != _CALIDAD_DE_QUALITY_SETTINGS.NON_INITIALIZED_INHERIT_FROM_ABOVE_METHODS )


        // 3.1- Obtener las Dimensiones de la Pantalla:
        //
        this._miTamanoPantallaX = Screen.width;
        this._miTamanoPantallaY = Screen.height;
        //
        // Setear la 'Resolucion' a usar de Pantalla (width x heigh), dados los valores entrados como INPUT del usuario via Menu 
        //...o atributo público de este Script: 'GameManager.cs'
        //
        this.SetResolucionDePantallaYAspectRatio((int)this._miCalidadDeResolucionPantalla);

    }//End Metodo


    #endregion Configuracion Grafica Global

    /// <summary>
    /// Sets the resolucion de pantalla Y aspect ratio.
    /// </summary>
    /// <param name="nuevaResolucion">Nueva resolucion.</param>
    public void SetResolucionDePantallaYAspectRatio(int calidadGraficaElegida)
    {
        // Nueva Resolucion:
        //
        float nuevaResolucion = (calidadGraficaElegida / 100.0f);


        /////Debug.Log("nuevaResolucion = " + nuevaResolucion);

        /////Debug.Log("RESOLUCION DE PANTALLA ANTES de aplicar algo = " + Screen.currentResolution);

        // Setear Nueva Resolucion:
        //
        Screen.SetResolution((int)(this._miTamanoPantallaX * nuevaResolucion), (int)(this._miTamanoPantallaY * nuevaResolucion), true);
        //
        // Radio de Aspecto:   Deshabilitado por ahora, hasta probar y decidir si es buena idea, o no:
        //
        ///OPCION A: this._miCamara.aspect = this._miTamanoPantallaX / _miTamanoPantallaY;
        // Fijar el ASPECT RATIO de la Cámara al mismo valor, por si acaso estaba perdiéndolo, debido a la línea anterior.
        //
        this._miCamaraRealDeLaApp.aspect = this._miTamanoPantallaX / this._miTamanoPantallaY;

    }//End Method

    #endregion Configuracion Grafica - Pantalla



    #endregion Configuracion del Juego


    #region Control y Botones de Menu del Juego

    /// <summary>
    /// Load the Main Menu.
    /// </summary>
    public void LoadHomeMainMenu()
    {
        // Before: (Pre-Demo) SceneManager.LoadScene("SandBox1", LoadSceneMode.Single);

        //        // DONT DO THIS. THROWS A WARNING and DOEŚN'T WORK:        // This line may not execute in modern UNITY3D Versions:  (Destroy)
        //        //
        //        this.DestroyActualScene();

        /////Debug.Log("LoadHomeMainMenu()");


        // Borrar la Basura:
        //
        // System.GC.Collect(); // Vieja implementación.
        // Nueva: 2019/09/19:
        //
        _miGarbageCollectionManager.GCCollectApagandoGCautomatico();


        // Load again active Scene:
        //
        SceneManager.LoadScene( /* Here WOULD BE the SCENE: ""MAIN MENU"". Temporary: Re-Load Active Scene */ SceneManager.GetActiveScene().name /* This Scene */, LoadSceneMode.Single);

    }//End Method


    /// <summary>
    /// Loads and Initializes this scene again.
    /// </summary>
    public void LoadThisSceneAgain()
    {

        //        // DONT DO THIS. THROWS A WARNING and DOEŚN'T WORK:        // This line may not execute in modern UNITY3D Versions:  (Destroy)
        //        //
        //        this.DestroyActualScene();

        /////Debug.Log("LoadThisSceneAgain()");

        // Borrar la Basura:
        //
        // System.GC.Collect(); // Vieja implementación.
        // Nueva: 2019/09/19:
        //
        _miGarbageCollectionManager.GCCollectApagandoGCautomatico();


        // Load again active Scene:
        //
        SceneManager.LoadScene( /* This Scene: */ SceneManager.GetActiveScene().name, LoadSceneMode.Single);

    }//End Method


    /// <summary>
    /// Destroys actual Scene, in order to call or Initialize another.
    /// NOTE: It may not execute in modern UNITY3D Versions.
    /// </summary>
    public void DestroyActualScene()
    {
        // This line may not execute in modern UNITY3D Versions:  (Destroy)
        //
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);

    }//End Method


    //    // load the nextLevel after delay
    //    IEnumerator LoadNextLevel() {
    //        yield return new WaitForSeconds(2.5f);
    //        SceneManager.LoadScene(levelAfterVictory);
    //    }


    #endregion Control y Botones de Menu del Juego

    #region Utility y Miscelaneos

    /// <summary>
    /// Casts the int32 to string with no Garbage IF AND ONLY IF: It is bellow a DEFAULTED VALUE: 30 (it is using a constant ATTRIBUTE FROM THIS CLASS ABOVE.)
    /// </summary>
    public void CastIntToStringNoGarbage(int inputNumber, Text inputOutput)
    {

        if (inputNumber <= _LENGTH_DE_NUMEROS_STRING_LIMITE_20)
        {
            // It is bellow the MAX capacity of the string. It is OK to use  it.
            //
            inputOutput.text = _NUMEROS_STRING_LIMITE_20[inputNumber];
        }
        else
        {
            // Generate Garbage, in the most optimized way (without using gstrings by vexe, or StringBuilder, which are way better):
            //
            inputOutput.text = inputNumber.ToString();

        }//End else

    }//End Method

    #endregion Utility y Miscelaneos


    #endregion Metodos que no son de Base de Unity

}
