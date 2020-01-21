using UnityEngine;
//using UnityEngine.UI;
//using System.Collections;
//// No necesario acá, pero sí en Script de Portero: ''ControlPortero2D.cs'':     
////using UnityStandardAssets.CrossPlatformInput; // include so we can use Cross-Platform Input (for mobile devices - i.e. Android, iOS, etc. - and for Standalone devices - Windows, Mac).
//using UnityEngine.SceneManagement;
///////using UnityEngine.Profiling;    // Profiler: COMENTAR CUANDO YA NO SE USE:


public class GameManager_referencia : MonoBehaviour
{

//    public static GameManager gm;

//    #region Configuración del Juego

//    //  DIFICULTAD

//    /// <summary>
//    /// Dificultad del Juego: FÁCIL, NORMAL o DIFICIL.
//    /// </summary>
//    //[Tooltip("Dificultad del Juego: FÁCIL, NORMAL o DIFICIL.")]
//    public enum _DIFICULTAD_DEL_JUEGO { FACIL, NORMAL, DIFICIL };

//    /// <summary>
//    /// Dificultad del Juego: FÁCIL, NORMAL o DIFICIL.
//    /// </summary>
//    [Tooltip("Dificultad del Juego: FÁCIL, NORMAL o DIFICIL.")]
//    public _DIFICULTAD_DEL_JUEGO _miDificultadDelJuegoElegida = _DIFICULTAD_DEL_JUEGO.FACIL;


//    /// <summary>
//    /// (readonly, no modificar)
//    /// Si GANÓ el JUEGO: es TRUE.
//    /// PERDIÓ el JUEGO: es FALSE.
//    /// </summary>
//    [Tooltip("(Readonly, no modificar)\nSi GANÓ el JUEGO: es TRUE.\nPERDIÓ el JUEGO: es FALSE.")]
//    public bool _miResultadoDelJuegoGaneOPerdi = false;


//    #region Corrutinas - Optimización

//    /// <summary>
//    /// The Delay play sonido GOL wait for seconds. It is for OPTIMIZATION.
//    /// </summary>
//    private WaitForSeconds[] _miListaDelayPlaySonidoGol_WaitForSeconds;   // = new WaitForSeconds( this._miAudioSourceComentarista.clip.length );


//    /// <summary>
//    /// The Delay play sonido NO GOL, wait for seconds. It is for OPTIMIZATION.
//    /// </summary>
//    private WaitForSeconds[] _miListaDelayPlaySonidoNoGol_WaitForSeconds;   // = new WaitForSeconds( this._miAudioSourceComentarista.clip.length );


//    /// <summary>
//    /// The Delay Comentario_Blooper_AlEntrarEnFaseDeSuddenDeath. La pantalla se pone color gris cuando ese Blooper, chistoso.
//    /// </summary>
//    private WaitForSeconds _miSonidoComentario_Blooper_AlEntrarEnFaseDeSuddenDeath_WaitForSeconds;   // = new WaitForSeconds( this._miSonidoComentario_Blooper_AlEntrarEnFaseDeSuddenDeath  /* this._miAudioSourceComentarista.clip.length */);


//    /// <summary>
//    /// The Delay Comentario_Blooper_AlEntrarEnFaseDeSuddenDeath. La pantalla se pone color gris cuando ese Blooper, chistoso.
//    /// </summary>
//    private WaitUntil _miScriptCamaraParaAnimacionAlGanarOPerderEnfocarMuchosPuntosYMoverseAMuchosDestinos_movermeAhora_WaitUntil;   // = new WaitUntil(() => (! this._miScriptCamaraParaAnimacionAlGanarOPerderEnfocarMuchosPuntosYMoverseAMuchosDestinos._movermeAhora));   

//    #endregion Corrutinas - Optimización


//    #region Render - Graphics

//    #region Resolucion de Pantalla - Calidad

//    // Calidad de RESOLUCION: Opciones.

//    /// <summary>
//    /// Calidad de: RESOLUCION de PANTALLA a usar en la App. Valor PORCENTUAL.
//    /// </summary>
//    public enum _CALIDAD_DE_RESOLUCION_PANTALLA { LD = 60, MD = 80, HD = 100 };

//    /// <summary>
//    /// Calidad de: RESOLUCION de PANTALLA a usar en la App. Valor PORCENTUAL:
//    /// 100 =>  HD
//    /// 80  =>  MD
//    /// 60  =>  LD
//    /// </summary>
//    [Tooltip("Calidad de: RESOLUCION de PANTALLA a usar en la App. Valor PORCENTUAL:\n* 100 =>  HD\n* 80  =>  MD\n* 60  =>  LD")]
//    public _CALIDAD_DE_RESOLUCION_PANTALLA _miCalidadDeResolucionPantalla = _CALIDAD_DE_RESOLUCION_PANTALLA.MD;


///*  Plan b:  CONSTANTES: */
////    /// <summary>
////    /// Opción de CALIDAD 'BAJA' de: RESOLUCION de PANTALLA a usar en la App. Valor PORCENTUAL: 60.
////    /// </summary>
////    private const int _MI_CALIDAD_DE_RESOLUCION_PANTALLA_LD = 60;
////
////    /// <summary>
////    /// Opción de CALIDAD 'MEDIA' de: RESOLUCION de PANTALLA a usar en la App. Valor PORCENTUAL: 80.
////    /// </summary>
////    private const int _MI_CALIDAD_DE_RESOLUCION_PANTALLA_MD = 80;
////
////    /// <summary>
////    /// Opción de CALIDAD 'MÁXIMA' de: RESOLUCION de PANTALLA a usar en la App. Valor PORCENTUAL: 100.
////    /// </summary>
////    private const int _MI_CALIDAD_DE_RESOLUCION_PANTALLA_HD = 100;
////
////
////    /// <summary>
////    /// Calidad de: RESOLUCION de PANTALLA a usar en la App. Valor PORCENTUAL:
////    /// 100 =>  HD
////    /// 80  =>  MD
////    /// 60  =>  LD
////    /// </summary>
////    [Tooltip("Calidad de: RESOLUCION de PANTALLA a usar en la App. Valor PORCENTUAL:\n* 100 =>  HD\n* 80  =>  MD\n* 60  =>  LD")]
////    public int _miCalidadDeResolucionPantalla = _MI_CALIDAD_DE_RESOLUCION_PANTALLA_LD;

//    /// <summary>
//    /// Tamano NATIVO de la pantalla (del dispositivo). X
//    /// </summary>
//    private float _miTamanoPantallaX = 800.0f;

//    /// <summary>
//    /// Tamano NATIVO de la pantalla (del dispositivo). Y
//    /// </summary>
//    private float _miTamanoPantallaY = 600.0f;


//    /// <summary>
//    /// FPS establecido para la App.
//    /// </summary>
//    public static readonly int _MI_FPS_CONSTANTE_MOBILE = 30;

//    /// <summary>
//    /// FPS establecido para la App.
//    /// </summary>
//    public static readonly int _MI_FPS_CONSTANTE_STANDALONE = 60;

//    #endregion Resolucion de Pantalla - Calidad


//    #region Quality Settings

//    /// <summary>
//    /// Calidad de: QUALITY SETTINGS a usar en la App.
//    /// </summary>
//    public enum _CALIDAD_DE_QUALITY_SETTINGS { NON_INITIALIZED_INHERIT_FROM_ABOVE_METHODS = -1, VERY_LOW = 0, LOW = 1, MEDIUM = 2, HIGH = 3, VERY_HIGH = 4, ULTRA = 5 };

//    /// <summary>
//    /// Calidad de: QUALITY SETTINGS a usar en la App.
//    /// </summary>
//    [Tooltip("Calidad de: QUALITY SETTINGS a usar en la App.")]
//    public _CALIDAD_DE_QUALITY_SETTINGS _miCalidadDeQualitySettings = _CALIDAD_DE_QUALITY_SETTINGS.MEDIUM;

//    #endregion Quality Settings

//    #endregion Render - Graphics

//    #endregion Configuración del Juego


//	#region Objetos del Juego

//	[Tooltip("El BALON. Por defecto este deberia ser el Balon.")]
//	public GameObject _miPlayer;

//	/// <summary>
//	/// The microphone input del balon.
//	/// </summary>
//	private MicrophoneInput _miMicrophoneInputDelBalon;

//	/// <summary>
//	/// Linea dentro de la Porteria, la cual, al ser atravesada (por el Balon): genera GOOOL!
//	/// </summary>
//	[Tooltip("Linea dentro de la Porteria, la cual, al ser atravesada (por el Balon): genera GOOOL!")]
//	public GameObject _miLineaDeGolMeta;

//	/// <summary>
//	/// Balon transparente que sirve de INDICADOR de DIRECCION para poder chutar.
//	/// </summary>
//	[Tooltip("Balon transparente que sirve de INDICADOR de DIRECCION para poder chutar")]
//	public GameObject _miBalonIndicadorParaApuntar;

    
//    /// <summary>
//    /// Script de la I.A. del Chutador (CPU con I.A.) del Balón.
//    /// </summary>
//    //[SerializeField]
//    private ConductaIAChutadorDelPenalty _miScriptConductaIAChutadorDelPenalty;

//    /// <summary>
//    /// Portero controlado por el Humano, P1
//    /// </summary>
//    [Tooltip("Portero controlado por el Humano, P1")]
//    public GameObject _miPorteroHumano;

//    /// <summary>
//    /// Transform de: Portero controlado por el Humano, P1
//    /// </summary>
//    private Transform _miPorteroHumano_Cabeza_Transform;


//	/// <summary>
//    /// Portero (CPU con I.A.) que intentará detener el Balón
//	/// </summary>
//	[Tooltip("Portero (CPU con I.A.) que intentará detener el Balón")]
//	public GameObject _miPorteroCPU;

//    /// <summary>
//    /// Transform de: Cabeza de: Portero (CPU con I.A.) que intentará detener el Balón
//    /// </summary>
//    private Transform _miPorteroCPU_Cabeza_Transform;


//	/// <summary>
//	/// Script acerca de la CONDUCTA DEL PORTERO (I.A.), e inicialización y variables necesarias del Objeto Portero.
//	/// </summary>
//    [HideInInspector]
//	public ConductaIAPortero _miScriptConductaPorteroCPU;

//    /// <summary>
//    /// Script acerca del Control del Portero-Humano (P1): inicialización y variables necesarias del Objeto Portero P1 (Humano).
//    /// </summary>
//    [HideInInspector]
//    public ControlPortero2D _miScriptControlPortero2D;


//	/// <summary>
//	/// Script acerca de la CONDUCTA DEL PORTERO (I.A.), e inicialización y variables necesarias del Objeto Portero.
//	/// </summary>
//    [HideInInspector]
//    public ConductaMovimientoBasicoIzqDer _miScriptConductaBalonIndicadorParaApuntar;

//	/// <summary>
//	/// Script acerca de la LÓGICA detrás de la Linea dentro de la Porteria, la cual, al ser atravesada (por el Balon): genera GOOOL!
//	/// </summary>
//	private LineaDeGol _miScriptLineaDeGol;

//    #endregion Objetos del Juego

//    #region Estados de Juego | Jugadores | Puntuaciones

//    #region Estados de Juego

//    /// <summary>
//    /// Estados del Juego Globales, por encima de todo.
//    /// </summary>
//    public enum _GAME_STATES {Playing, BeatLevel, Death, GameOver};

//	/// <summary>
//	/// Estados del Juego particulares: durante el ""gameState"": PLAYING.
//	/// </summary>
//    public enum _GAME_STATES_WHEN_PLAYING {InicializacionFinalVariables, PreparandoVariablesParaChutar, EsperandoPorAnimacionPeligroDeTerminarJuego, EsperandoPorGUIRoundNumero, PorChutar, Chutando, CelebracionGol, CelebracionNoEsGol, AnimacionChutadorGol, AnimacionChutadorNoEsGol, AnimacionPorteroParadaExitosa, AnimacionPorteroFallo, AnimacionInicioSuddenDeath /* NO SE USARÁN:  , AntesDePortear, Porteando */ };

//    /// <summary>
//    /// ESTADO: Esta la App pausada? O no?
//    /// </summary>
//    [Tooltip("ESTADO: Esta la App pausada? O no?")]
//    public bool _appEstaPausada = false;

//    /// <summary>
//    /// Si es TRUE: Se Activará INMEDIATAMENTE un CAMBIO DE ESTADO: Pausar/Despausar.
//    /// </summary>
//    [Tooltip("Si es TRUE: Se Activará INMEDIATAMENTE un CAMBIO DE ESTADO: Pausar/Despausar.")]
//    public bool _appCambiarDeEstadoTogglePauseODespause = false;

//    /// <summary>
//    /// Estado Global del Juego.
//    /// </summary>
//    [Tooltip("Estado Global del Juego.")]
//	public _GAME_STATES _mainGameState = _GAME_STATES.Playing;

//    /// <summary>
//    /// Estado Particular del Juego en PLAYING.
//    /// </summary>
//    [Tooltip("Estado Particular del Juego en PLAYING.")]
//    public _GAME_STATES_WHEN_PLAYING _gameStateWhenPlaying = _GAME_STATES_WHEN_PLAYING.PreparandoVariablesParaChutar;

//    #endregion Estados de Juego

//    #region Jugadores y Turnos

//    /// <summary>
//    /// Jugadores posibles y su código.
//    /// </summary>
//    public enum _JUGADORES { NINGUNO, CPU1, CPU2, P1, P2, P3, P4, P5 };

//	/// <summary>
//	/// Jugador UNO, usuario del Juego. PLAYER (generalmente es P1)
//	/// </summary>
//	public _JUGADORES _miJugadorUNO = _JUGADORES.P1;

//	/// <summary>
//	/// Jugador DOS (generalmente es CPU)
//	/// </summary>
//	public _JUGADORES _miJugadorCPU = _JUGADORES.CPU1;

//	/// <summary>
//	/// Jugador por disparar a porteria
//	/// </summary>
//    [SerializeField]
//	private _JUGADORES _miJugadorActualQueChuta = _JUGADORES.P1;

//    /// <summary>
//    /// Jugador que Portea
//    /// </summary>
//    [SerializeField]
//    private _JUGADORES _miJugadorActualQuePortea = _JUGADORES.CPU1;


//	/// <summary>
//	/// Indica el turno-chute actual, es un numero de 1 a 5, en la primera tanda de 5 chutes. Si continua (en SEGUNDA TANDA de 5): se vuelve de 6 a 10 (restandole -5).
//	/// </summary>
//    [Tooltip("Indica el turno-chute actual, es un numero de 1 a 5, en la primera tanda de 5 chutes. Si continua (en SEGUNDA TANDA de 5): se vuelve de 6 a 10 (restandole -5).")]
//	public int _numeroOrdinalDeTurnoJugadorUNO = 1;

//    /// <summary>
//    /// Indica el turno-chute actual, es un numero de 1 a 5, en la primera tanda de 5 chutes. Si continua (en SEGUNDA TANDA de 5): se vuelve de 6 a 10 (restandole -5).
//    /// </summary>
//    [Tooltip("Indica el turno-chute actual, es un numero de 1 a 5, en la primera tanda de 5 chutes. Si continua (en SEGUNDA TANDA de 5): se vuelve de 6 a 10 (restandole -5).")]
//    public int _numeroOrdinalDeTurnoJugadorCPU = 1;

//	/// <summary>
//	/// Indica cuántos turnos hay por tanda/Round de chutes.
//	/// </summary>
//	private readonly int _NUMERO_DE_TURNOS_POR_TANDA = 5;

//    /// <summary>
//    /// Indica el grupo de 5 ROUNDs / 5 Tandas juntas, del Penalty.
//    /// </summary>
//    [Tooltip("Indica el grupo de 5 ROUNDs / 5 Tandas juntas, del Penalty")]
//    public int _numeroOrdinalDe5Rounds = 1;

//    #endregion Jugadores y Turnos

//    #region Puntuaciones de los Jugadores

//    /// <summary>
//    /// Puntuacion SCORE del jugador (OJO: No son los goles, sino Puntos-ORO de Juego). Incluye la toma de Bonos que aparezcan en el camino.
//    /// </summary>
//    public int _scorePuntosOroP1 = 0;

//	/// <summary>
//	/// Puntos de EXPERIENCIA (XP) del jugador. Incluye la toma de Bonos que aparezcan en el camino.
//	/// </summary>
//	public int _scorePuntosXpP1 = 0;

//	/// <summary>
//	/// Goles metidos por el Jugador # 1.
//	/// </summary>
//    [Tooltip("Goles metidos por el Jugador #1: P1")]
//	public int _golesAnotadosP1 = 0;

//    /// <summary>
//    /// Goles metidos por el Jugador # 2.
//    /// </summary>
//    [Tooltip("Goles metidos por el Jugador # 2")]
//    public int _golesAnotadosP2 = 0;


//	/// <summary>
//	/// Bandera que permite saber si se debe ""Tomar Nota"" de un Gol Reciente (tanto en variables, como en la GUI).
//	/// </summary>
//	[HideInInspector]
//	public bool _faltaTomarNotaDelGolReciente = false;

//	/// <summary>
//	/// Puntuacion de ORO (SCORE) del jugador que se le regalará al meter un GOL.
//	/// </summary>
//	[Tooltip("Puntuacion de ORO (SCORE) del jugador que se le regalará al meter un GOL")]
//	public int _puntosDeOroAlMeterGOL = 10;

//	/// <summary>
//	/// Puntuacion de EXPERIENCIA (XP) del jugador que se le regalará al meter un GOL.
//	/// </summary>
//	[Tooltip("Puntuacion de EXPERIENCIA (XP) del jugador que se le regalará al meter un GOL")]
//	public int _puntosDeExperienciaXPGol = 5;

//	/// <summary>
//	/// Puntuacion de ORO (SCORE) del jugador que se le regalará al cobrar un PENALTY sin hacer GOL (es decir: FALLAR).
//	/// </summary>
//	[Tooltip("Puntuacion de ORO (SCORE) del jugador que se le regalará al cobrar un PENALTY sin hacer GOL (es decir: FALLAR)")]
//	public int _puntosDeOroAlFallarElChute = 1;

//	/// <summary>
//	/// Puntuacion de EXPERIENCIA (XP) del jugador que se le regalará al cobrar un PENALTY sin hacer GOL (es decir: FALLAR).
//	/// </summary>
//	[Tooltip("Puntuacion de EXPERIENCIA (XP) del jugador que se le regalará al cobrar un PENALTY sin hacer GOL (es decir: FALLAR)")]
//	public int _puntosDeExperienciaXPFallandoElChute = 1;

//    #endregion Puntuaciones de los Jugadores

//    #endregion Estados de Juego | Jugadores | Puntuaciones


//    #region GUI

//    //public bool canBeatLevel = false;
//    //public int beatLevelScore=0;

//    // GUI
//    //	public GameObject mainCanvas;
//    //	public Text mainScoreDisplay;

//    #region Menu PAUSE / LET'S PLAY

//    /// <summary>
//    /// GUI Canvas 'Menu PAUSE / LET'S PLAY': que aparece cuando el Juego es Pausado.
//    /// </summary>
//    [Tooltip("Componente CANVAS (GUI) del GameObject de GUI de: 'Menu PAUSE / LET'S PLAY': que aparece cuando el Juego es Pausado.\n * Para Activar / Desactivar de forma eficiente la GUI, evitando el método OnEnable()/OnDisable().")]
//    public Canvas _miMenuPauseGUIComponenteCanvasEnGameObjectCanvas;

//    #endregion Menu PAUSE / LET'S PLAY

//    #region ROUND X / TANDA

//    //    ///////////////////QUITAR ÉSTE:
//    /// <summary>
//    /// (Usado sólo por ROBUSTEZ, para INICIALIZAR al 'COMPONENTE CANVAS', que sí es óptimo usar.POR RAZONES DE OPTIMIZACIÓN, usar el COMPONENTE CANVAS, atributo de abajo de éste):\n GUI Canvas de Round/Tanda X
//    /// </summary>
//    [Tooltip("(Usado sólo por ROBUSTEZ, para INICIALIZAR al 'COMPONENTE CANVAS', que sí es óptimo usar.POR RAZONES DE OPTIMIZACIÓN, usar el COMPONENTE CANVAS, atributo de abajo de éste):\n * GUI Canvas de Round/Tanda X")]
//	public GameObject _miRoundTandaGUICanvas;
    
//    /// <summary>
//    /// GUI Canvas de Round/Tanda X.
//    /// </summary>
//    [Tooltip("Componente CANVAS (GUI) del GameObject 'Canvas' de Round/Tanda X.\n * Para Activar / Desactivar de forma eficiente la GUI, evitando el método OnEnable()/OnDisable().")]
//    private Canvas _miRoundTandaGUIComponenteCanvasEnGameObjectCanvas;

////    /// <summary>
////    /// Rectangulo (GUI) PADRE de 'UI Text': Round/Tanda X (HIJO directo del Canvas)
////    /// </summary>
////    [Tooltip("Rectangulo (GUI) PADRE de 'UI Text': Round/Tanda X (HIJO directo del Canvas)")]
////    public GameObject _miRoundTandaGUIRect;

//    /// <summary>
//    /// Script para Animaciones de GUI: 'TweensRoundXv3.cs', el cual ACTIVA-ENCIENDE o APAGA un TWEEN / ANIMACION de letras 'ROUND X'.\n Va pegado como COMPONENTE al RECTANGULO (Rect) que es Padre del grupo de Letras que se moverán juntas al unísono con la Animación.
//    /// </summary>
//    [Tooltip("Script para Animaciones de GUI: 'TweensRoundXv3.cs', el cual ACTIVA-ENCIENDE o APAGA un TWEEN / ANIMACION de letras 'ROUND X'.\n * Va pegado como COMPONENTE al RECTANGULO (Rect) que es Padre del grupo de Letras que se moverán juntas al unísono con la Animación.")]
//    public TweensRoundXv3 _miScriptTweensRoundX;

//    /// <summary>
//    /// GUI de Texto de Round/Tanda X (es la "X")
//    /// </summary>
//    [Tooltip("GUI de Texto de Round/Tanda X (es la 'X')")]
//    public Text _miRoundTandaGUIText_Numero;

//    #endregion ROUND X / TANDA


//    #region Score Final. Ejemplo: (0 - 0) en Texto

////    ///////////////////QUITAR ÉSTE:
//    /// <summary>
//    /// (Usado sólo por ROBUSTEZ, para INICIALIZAR al 'COMPONENTE CANVAS', que sí es óptimo usar.POR RAZONES DE OPTIMIZACIÓN, usar el COMPONENTE CANVAS, atributo de abajo de éste):\n * GUI CANVAS que contiene todos las Cajas de Texto de Score Final.
//    /// </summary>
//    [Tooltip("(Usado sólo por ROBUSTEZ, para INICIALIZAR al 'COMPONENTE CANVAS', que sí es óptimo usar.POR RAZONES DE OPTIMIZACIÓN, usar el COMPONENTE CANVAS, atributo de abajo de éste):\n * GUI CANVAS que contiene todos las Cajas de Texto de Score Final.")]
//    public GameObject _miGUIContenedoraDeScoreGolesAnotadosTextos;


//    // Se usará para ACTIVAR - DESACTIVAR EL ""CANVAS"", EFICIENTEEEEE::::::
//    /// <summary>
//    /// Componente CANVAS (GUI) del GameObject 'Canvas' de GUI que contiene todas las Cajas de Texto de Score Final.\n Para Activar / Desactivar de forma eficiente la GUI, evitando el método OnEnable()/OnDisable().
//    /// </summary>
//    [Tooltip("Componente CANVAS (GUI) del GameObject 'Canvas' de GUI que contiene todas las Cajas de Texto de Score Final.\n * Para Activar / Desactivar de forma eficiente la GUI, evitando el método OnEnable()/OnDisable().")]
//    private Canvas _miScoreGolesAnotadosTextosComponenteCanvasEnGameObjectCanvas;

////  COMENTADO TEMPORALMENTE, PARA PRUEBAS DE PERFORMANCE:::::
//    /// <summary>
//    /// Script para Animaciones de GUI: 'TweensScoreAvsBv3.cs', el cual ACTIVA-ENCIENDE o APAGA un TWEEN / ANIMACION de letras 'Score (ejemplo '(1 - 0)')'.\n Va pegado como COMPONENTE al RECTANGULO (Rect) que es Padre del grupo de Letras que se moverán juntas al unísono con la Animación.
//    /// </summary>
//    [Tooltip("Script para Animaciones de GUI: 'TweensScoreAvsBv3.cs', el cual ACTIVA-ENCIENDE o APAGA un TWEEN / ANIMACION de letras 'Score (ejemplo '(1 - 0)')'.\n * Va pegado como COMPONENTE al RECTANGULO (Rect) que es Padre del grupo de Letras que se moverán juntas al unísono con la Animación.")]
//    public TweensScoreAvsBv3 _miScriptTweensScoreAvsBv3;


//    /// <summary>
//    /// GUI de Texto de Score Final, para el Jugador de la IZQUIERDA (P1).
//    /// </summary>
//    [Tooltip("GUI de Texto de Score Final, para el Jugador de la IZQUIERDA (P1).")]
//    public Text _miTextoGolesP1EnGuiScoreGolesAnotados;

//    /// <summary>
//    /// GUI de Texto de Score Final, para el Jugador de la DERECHA (P2).
//    /// </summary>
//    [Tooltip("GUI de Texto de Score Final, para el Jugador de la DERECHA (P2).")]
//    public Text _miTextoGolesP2EnGuiScoreGolesAnotados;

//    #endregion Score Final. Ejemplo: (0 - 0) en Texto

//    // Eliminado del Proyecto. Sustituido por:  LETRAS DE ORO Y PLATA DE GOAL.
//    //
////	/// <summary>
////	/// GUI de Anuncio de GOL!!! Durante animacion.
////	/// </summary>
////	[Tooltip("GUI de Anuncio de GOL!!! Durante animacion")]
////	public GameObject _miGolGUICanvas;
////
////    /// <summary>
////    /// GUI de Anuncio de que NO fue GOL!!! Durante animacion
////    /// </summary>
////    [Tooltip("GUI de Anuncio de que NO fue GOL!!! Durante animacion")]
////    public GameObject _miNoGolGUICanvas;

//	/// <summary>
//	/// Variable marca el tiempo maximo para tomar nota del Gol, recién anotado.
//	/// </summary>
//	private readonly float _TIEMPO_MAXIMO_EMPEZAR_TOMAR_NOTA_DEL_GOL = 0.5f;

//	/// <summary>
//	/// Variable marca el tiempo maximo para la ANIMACION ""ROUND/TANDA X""
//	/// </summary>
//	private readonly float _TIEMPO_MAXIMO_ANIMACION_TANDA_RONDA_GUI = 3.5f;


////  // ELIMINADO: Por OPTIMIZACIÓN DE RAM / CPU.
////	/// <summary>
////	/// GUI de Texto de Puntos de ORO
////	/// </summary>
////	[Tooltip("GUI de Texto de Puntos de ORO")]
////	public Text _miPuntosOroGUI;

////  // ELIMINADO: Por OPTIMIZACIÓN DE RAM / CPU.
////	/// <summary>
////	/// GUI de Texto de Puntos de ORO
////	/// </summary>
////	[Tooltip("GUI de Texto de Puntos de EXPERIENCIA (XP)")]
////	public Text _miPuntosXPGUI;


//	/// <summary>
//	/// Objetos de la UI que representan las imagenes de Goles anotados (el Score Board o Pizarrón de Goles).
//	/// </summary>
//	[Tooltip("De P1: Objetos de la UI (tipo: Image) que representan las imagenes de Goles anotados (el Score Board o Pizarrón de Goles).")]
//	public Image[] _p1GolesImagenesUI;

//    /// <summary>
//    /// Longitud de Array: Objetos de la UI que representan las imagenes de Goles anotados (el Score Board o Pizarrón de Goles).
//    /// </summary>
//    //[Tooltip("De P1: Objetos de la UI (tipo: Image) que representan las imagenes de Goles anotados (el Score Board o Pizarrón de Goles).")]
//    [HideInInspector]
//    public int _p1GolesImagenesUI_Longitud;


//    /// <summary>
//    /// Objetos de la UI que representan las imagenes de Goles anotados (el Score Board o Pizarrón de Goles).
//    /// </summary>
//    [Tooltip("De P2: Objetos de la UI (tipo: Image) que representan las imagenes de Goles anotados (el Score Board o Pizarrón de Goles).")]
//    public Image[] _p2GolesImagenesUI;

//    /// <summary>
//    /// Longitud de: Objetos de la UI que representan las imagenes de Goles anotados (el Score Board o Pizarrón de Goles).
//    /// </summary>
//    //[Tooltip("De P2: Objetos de la UI (tipo: Image) que representan las imagenes de Goles anotados (el Score Board o Pizarrón de Goles).")]
//    [HideInInspector]
//    public int _p2GolesImagenesUI_Longitud;


//    /// <summary>
//    /// Objetos de la UI (tipo: Text) que representan los números (UI Text) de los Goles anotados (el Score Board o Pizarrón de Goles).
//    /// </summary>
//    [Tooltip("De P1: Objetos de la UI (tipo: Text) que representan los números (UI Text) de los Goles anotados (el Score Board o Pizarrón de Goles).")]
//    public Text[] _p1GolesTextoUI;

//    /// <summary>
//    /// Objetos de la UI (tipo: Text) que representan los números (UI Text) de los Goles anotados (el Score Board o Pizarrón de Goles).
//    /// </summary>
//    [Tooltip("De P2: Objetos de la UI (tipo: Text) que representan los números (UI Text) de los Goles anotados (el Score Board o Pizarrón de Goles).")]
//    public Text[] _p2GolesTextoUI;


//	// OJO: Quitar o decidir QUE HACER CON ESTO (FALTA LA IMPLEMENTACION DE GUI DE: ""GAME OVER"" O ""FELICIDADES""/""VICTORIA"", etc, al Ganar!)
////	public GameObject gameOverCanvas;
////	public Text gameOverScoreDisplay;
//	//
//	// OJO: Quitar o decidir QUE HACER CON ESTO (FALTA LA IMPLEMENTACION DE GUI DE: ""GAME OVER"" O ""FELICIDADES""/""VICTORIA"", etc, al Ganar!)
//	//
////	[Tooltip("Only need to set if canBeatLevel is set to true.")]
////	public GameObject beatLevelCanvas;
////	[Tooltip("This is a Score container in case you beat the Level. Only need to set if canBeatLevel is set to true.")]
////	public Text beatLevelScoreDisplay;

//    // Constantes de Colores para los Semáforos (GUI) que muestran los GOLES en el PANEL- Barra Negra:

//    /// <summary>
//    /// Color de "Round no visitado aún..."; usado en el Panel Superior de Score GUI de Goles, sobre la Barra Negra.
//    /// </summary>
//    [Tooltip("Color de 'Round no visitado aún...'; usado en el Panel Superior de Score GUI de Goles, sobre la Barra Negra.")]
//    private static readonly Color _MI_COLOR_SEMAFORO_ROUND_CHUTE_NO_DISPARADO_AUN = Color.white;

//    /// <summary>
//    /// Color de "Round con Gol Anotado..."; usado en el Panel Superior de Score GUI de Goles, sobre la Barra Negra.
//    /// </summary>
//    [Tooltip("Color de 'Round con Gol Anotado...'; usado en el Panel Superior de Score GUI de Goles, sobre la Barra Negra.")]
//    private static readonly Color _MI_COLOR_SEMAFORO_ROUND_GOL_ANOTADO = Color.green;

//    /// <summary>
//    /// Color de "Round con Gol Fallado..."; usado en el Panel Superior de Score GUI de Goles, sobre la Barra Negra.
//    /// </summary>
//    [Tooltip("Color de 'Round con Gol Fallado...'; usado en el Panel Superior de Score GUI de Goles, sobre la Barra Negra.")]
//    private static readonly Color _MI_COLOR_SEMAFORO_ROUND_GOL_FALLADO = Color.red;


//////  // ELIMINADO: Optimización de RAM / CPU.
////    /// <summary>
////    /// Imagen (Sprite) usada en el Panel Superior de Score GUI de Goles, sobre la Barra Negra.
////    /// </summary>
////    [Tooltip("Imagen (Sprite) usada en el Panel Superior de Score GUI de Goles, sobre la Barra Negra.")]
////    public Sprite _miImagenChuteNoDisparadoAun;

//////  // ELIMINADO: Optimización de RAM / CPU.
////	/// <summary>
////	/// Imagen usada cuando aun NO se chuta a GOL. Marcador de Goles.
////	/// </summary>
////	public Sprite _miImagenChuteNoDisparadoAun;
////
//////  // ELIMINADO: Optimización de RAM / CPU.
////	/// <summary>
////	/// Imagen usada cuando se mete un GOL.
////	/// </summary>
////	public Sprite _miImagenGolAnotado;
////
//////  // ELIMINADO: Optimización de RAM / CPU.
////	/// <summary>
////	/// Imagen usada cuando NO se mete un GOL.
////	/// </summary>
////	public Sprite _miImagenGolFallado;

////  // ELIMINADO: Optimización de RAM / CPU.
////
////	[Tooltip("GUI Canvas del tiempo durante animaciones")]
////	public GameObject _miTiempoGUICanvas;

////  // ELIMINADO: Optimización de RAM / CPU.
////	/// <summary>
////	/// Texto (GUI) de Tiempo transcurrido.
////	/// </summary>
////	public Text _miTiempoGUIText;

//	/// <summary>
//	/// Variable que cuenta el tiempo transcurrido entre transiciones del Juego.
//	/// </summary>
//	private float _miTiempo = 0.0f;

//    /// <summary>
//    /// Variable que cuenta el tiempo transcurrido entre transiciones del Juego.
//    /// </summary>
//    private bool _terminarAbruptamenteDeContarMiTiempoEntreFases = false;

//    /// <summary>
//    /// GUI (CANVAS COMPONENTs, OJO: NO es el GameObject(s) sino el(los) 'COMPONENTE(s)'; y puede ser más de uno: \n 1- Estático - Letras\n 2- Dinámico - el Slider en sí) que contiene el SLIDER de 'Sensibilidad del RECONOCIMIENTO DE SONIDOS'. Es el Canvas del Grupo, incluyendo al Texto de ''Sensitivity''. Es para hacer INVISIBLE todo el paquete al final en el GAME OVER. OJO: NO es el CANVAS GENERAL QUE CONTIENE EL PANEL DE GOLES ANOTADOS, s más pequeno y está más abajo en la Jerarquía.
//    /// </summary>
//    [Tooltip("GUI (CANVAS COMPONENTs, OJO: NO es el GameObject(s) sino el(los) 'COMPONENTE(s)'; y puede ser más de uno: \n 1- Estático - Letras\n 2- Dinámico - el Slider en sí) que contiene el SLIDER de 'Sensibilidad del RECONOCIMIENTO DE SONIDOS'. Es el Canvas del Grupo, incluyendo al Texto de ''Sensitivity''. \nEs para hacer INVISIBLE todo el paquete al final en el GAME OVER. \nOJO: NO es el CANVAS GENERAL QUE CONTIENE EL PANEL DE GOLES ANOTADOS, s más pequeno y está más abajo en la Jerarquía.")]
//    //public Canvas[] _misCanvasComponentUIDelSliderReconocimientoDeSonidos;
//    public /*GameObject*/  Object[] _misCanvasComponentUIDelSliderReconocimientoDeSonidos;

//    /// <summary>
//    /// Longitud de: GUI (CANVAS COMPONENTs, OJO: NO es el GameObject(s) sino el(los) 'COMPONENTE(s)'; y puede ser más de uno: \n 1- Estático - Letras\n 2- Dinámico - el Slider en sí) que contiene el SLIDER de 'Sensibilidad del RECONOCIMIENTO DE SONIDOS'. Es el Canvas del Grupo, incluyendo al Texto de ''Sensitivity''. Es para hacer INVISIBLE todo el paquete al final en el GAME OVER. OJO: NO es el CANVAS GENERAL QUE CONTIENE EL PANEL DE GOLES ANOTADOS, s más pequeno y está más abajo en la Jerarquía.
//    /// </summary>
//    //[Tooltip("Longitud de: GUI (CANVAS COMPONENTs, OJO: NO es el GameObject(s) sino el(los) 'COMPONENTE(s)'; y puede ser más de uno: \n 1- Estático - Letras\n 2- Dinámico - el Slider en sí) que contiene el SLIDER de 'Sensibilidad del RECONOCIMIENTO DE SONIDOS'. Es el Canvas del Grupo, incluyendo al Texto de ''Sensitivity''. \nEs para hacer INVISIBLE todo el paquete al final en el GAME OVER. \nOJO: NO es el CANVAS GENERAL QUE CONTIENE EL PANEL DE GOLES ANOTADOS, s más pequeno y está más abajo en la Jerarquía.")]
//    //public Canvas[] _misCanvasComponentUIDelSliderReconocimientoDeSonidos;
//    [HideInInspector]
//    public int _misCanvasComponentUIDelSliderReconocimientoDeSonidos_Longitud;


//    /// <summary>
//    /// Sensibilidad del Slider (GUI) de RECONOCIMIENTO DE SONIDOS.
//    /// </summary>
//    [Tooltip("Sensibilidad del Slider (GUI) de RECONOCIMIENTO DE SONIDOS")]
//	public Slider _miSliderReconocimientoDeSonidos;

//    /// <summary>
//    /// Valor DEFAULT (al iniciar la App y videojuego) DE: Sensibilidad del Slider (GUI) de RECONOCIMIENTO DE SONIDOS.
//    /// </summary>
//    ///[Tooltip("Valor DEFAULT (al iniciar la App y videojuego) DE: Sensibilidad del Slider (GUI) de RECONOCIMIENTO DE SONIDOS.")]
//    private float _miVolumenDeSensibilidadDefaultMicrofono;

//    #region Ecuacion linea recta SENSIBILIDAD MICROFONO VS. MASTER VOLUME

//    // Caso 1: VOLUMEN DE Sonidos del Silbato

//    /// <summary>
//    /// Valor de volumen MINIMO para los SILBATAZOS del ARBITRO.
//    /// </summary>
//    [Tooltip("Valor de volumen MINIMO para los SILBATAZOS del ARBITRO.")]
//    public float _volumenMinimoSilbatos = 0.0f;

//    /// <summary>
//    /// Valor de volumen MAXIMO para los SILBATAZOS del ARBITRO.
//    /// </summary>
//    [Tooltip("Valor de volumen MAXIMO para los SILBATAZOS del ARBITRO.")]
//    public float _volumenMaximoSilbatos = 0.5f;

//    /// <summary>
//    /// Valor de ''m'' PENDIENTE DE gráfica de LÍNEA RECTA DE: Sensibilidad del Slider (X) (GUI) de RECONOCIMIENTO DE SONIDOS (Y) vs Volumen Sonidos.
//    /// </summary>
//    ///[Tooltip("Valor de ''m'' PENDIENTE DE gráfica de LÍNEA RECTA DE: Sensibilidad del Slider (X) (GUI) de RECONOCIMIENTO DE SONIDOS (Y) vs Volumen Sonidos.")]
//    private float _miPendienteM_SensibilidadMicVsVolumenSilbatos;

//    /// <summary>
//    /// Valor de INTERCEPTO EN EL ORIGEN ''b'' DE gráfica de LÍNEA RECTA DE: Sensibilidad del Slider (X) (GUI) de RECONOCIMIENTO DE SONIDOS (Y) vs Volumen Sonidos.
//    /// </summary>
//    ///[Tooltip("Valor de INTERCEPTO EN EL ORIGEN ''b'' DE gráfica de LÍNEA RECTA DE: Sensibilidad del Slider (X) (GUI) de RECONOCIMIENTO DE SONIDOS (Y) vs Volumen Sonidos.")]
//    private float _miOrdenadaEnOrigenB_SensibilidadMicVsVolumenSilbatos;


//    // Caso 2: VOLUMEN DE Sonidos de Bulla de Fondo del Público constante.

//    /// <summary>
//    /// Valor de volumen MINIMO para la BULLA DE FONDO DEL PÚBLICO.
//    /// </summary>
//    [Tooltip("Valor de volumen MINIMO para la BULLA DE FONDO DEL PÚBLICO.")]
//    public float _volumenMinimoBullaFondoPublico = 0.0f;

//    /// <summary>
//    /// (readonly porque se verá desde el GO hijo de MainCamera: 'SonidosDelJuego') Valor de volumen MAXIMO para la BULLA DE FONDO DEL PÚBLICO.
//    /// </summary>
//    [Tooltip("Valor de volumen MAXIMO para la BULLA DE FONDO DEL PÚBLICO.")]
//    public float _volumenMaximoBullaFondoPublico = 0.2f;

//    /// <summary>
//    /// Valor de ''m'' PENDIENTE DE gráfica de LÍNEA RECTA DE: Sensibilidad del Slider (X) (GUI) de RECONOCIMIENTO DE SONIDOS (Y) vs Volumen Sonidos.
//    /// </summary>
//    ///[Tooltip("Valor de ''m'' PENDIENTE DE gráfica de LÍNEA RECTA DE: Sensibilidad del Slider (X) (GUI) de RECONOCIMIENTO DE SONIDOS (Y) vs Volumen Sonidos.")]
//    private float _miPendienteM_SensibilidadMicVsVolumenBullaPublicoFondo;

//    /// <summary>
//    /// Valor de INTERCEPTO EN EL ORIGEN ''b'' DE gráfica de LÍNEA RECTA DE: Sensibilidad del Slider (X) (GUI) de RECONOCIMIENTO DE SONIDOS (Y) vs Volumen Sonidos.
//    /// </summary>
//    ///[Tooltip("Valor de INTERCEPTO EN EL ORIGEN ''b'' DE gráfica de LÍNEA RECTA DE: Sensibilidad del Slider (X) (GUI) de RECONOCIMIENTO DE SONIDOS (Y) vs Volumen Sonidos.")]
//    private float _miOrdenadaEnOrigenB_SensibilidadMicVsVolumenBullaPublicoFondo;

//    #endregion Ecuacion linea recta SENSIBILIDAD MICROFONO VS. MASTER VOLUME

//    #region Control y Botones de Menu del Juego

//    // Botones de:  GAME OVER

//    /// <summary>
//    /// 'GUI Canvas' al aparecer el GAME OVER: RE-PLAY o HOME buttons.
//    /// </summary>
//    [Tooltip("'GUI Canvas' al aparecer el GAME OVER: RE-PLAY o HOME buttons.")]
//    public GameObject _miGameOverButtonsGUICanvas;

//    #endregion Control y Botones de Menu del Juego

//	#endregion GUI

//    #region Variables de Animaciones

//    /// <summary>
//    /// Duracion de tiempo en segundos desde que el Portero atrape la pelota, o ésta se detenga (o rebote de uno de los postes o manos del Portero).
//    /// </summary>
//    [HideInInspector]
//    public readonly float _TIEMPO_BALON_DETENIDO_EN_PORTERIA = 3.0f;

////    /// <summary>
////    /// <para> (readonly EN USO ACTUAL - EXPERIMENTAL) Valor del TIEMPO para que entre en 'CÁMARA LENTA' o 'CAMARA RÁPIDA'. Usar este valor Global. </para>
////    /// <para> -> 1 =         Velocidad NORMAL </para>
////    /// <para> -> MENOR A 1 = Velocidad LENTA. </para>
////    /// <para> -> 0 =         Totalmente DETENIDO (STOP!). </para>
////    /// <para> -> MAYOR A 1 = Velocidad RÁPIDA. </para>
////    /// </summary>
////    [Tooltip("(readonly EN USO ACTUAL - EXPERIMENTAL) Valor del TIEMPO para que entre en 'CÁMARA LENTA' o 'CAMARA RÁPIDA'. Usar este valor Global.\n 1 =         Velocidad NORMAL \n MENOR A 1 = Velocidad LENTA. \n 0 =         Totalmente DETENIDO (STOP!). \n MAYOR A 1 = Velocidad RÁPIDA.")]
////    [Range(0.0f, 10.0f)]
////    public float _miVelocidadDelTiempoGlobal =  0.667f;
////
////    /// <summary>
////    /// <para> (readonly EN USO ACTUAL - EXPERIMENTAL) Para usar el parámetro de abajo '_miEscalaDeTiempoDeltaTimeCamaraLenta', y establecer una VELOCIDAD DEL TIEMPO DIFERENTE (cámara lenta). </para>
////    /// <para> -> FALSE => IGNORARÁ los valores de abajo (de cámara lenta) </para>
////    /// <para> -> TRUE  => USARÁ los valores de abajo (de cámara lenta) </para>
////    /// </summary>
////    [Tooltip("(readonly EN USO ACTUAL - EXPERIMENTAL) Para usar el parámetro de abajo '_miEscalaDeTiempoDeltaTimeCamaraLenta', y establecer una VELOCIDAD DEL TIEMPO DIFERENTE (cámara lenta).")]
////    public bool _usarCamaraLentaGlobal = true;

//    /// <summary>
//    /// <para> (readonly) Valor del TIEMPO de las  FÍSICAS, para que entre en 'CÁMARA LENTA'. </para>
//    /// <para> -> 1 =         Velocidad NORMAL </para>
//    /// <para> -> MENOR A 1 = Velocidad LENTA. </para>
//    /// <para> -> 0 =         Totalmente DETENIDO (STOP!). </para>
//    ///
//    /// NOTA: Cada número corresponde a una DIFICULTAD del JUEGO: inicial <=> FACIL; segundo <=> NORMAL; tercero <=> AVANZADO.
//    /// </summary>
//    [Tooltip("(readonly) Valor del TIEMPO para que entre en 'CÁMARA LENTA'.\n 1 =         Velocidad NORMAL \n MENOR A 1 = Velocidad LENTA. \n 0 =         Totalmente DETENIDO (STOP!).\n\nNOTA: Cada número corresponde a una DIFICULTAD del JUEGO: inicial <=> FACIL; segundo <=> NORMAL; tercero <=> AVANZADO.")]
//    //[Range(0.0f, 1.0f)]
//    public float[] _miEscalaDeTiempoDeltaTimeCamaraLenta = new float[] { 0.6f, 0.7f, 0.81f } ;

//    /// <summary>
//    /// Valor del TIEMPO (estado DEFAULT - DE FÁBRICA) para la FÍSICA (FixedDeltaTime).
//    /// </summary>
//    [Tooltip("Valor del TIEMPO (estado DEFAULT - DE FÁBRICA) para la FÍSICA (FixedDeltaTime).")]
//    private readonly float _MI_FIXED_DELTA_TIME_DE_FABRICA = 0.02F;   // 0.025F; = son 40 Hz    // 0.0333334f;     // Original: 0.02F; son 50 Hz


//    /// <summary>
//    /// <para> (readonly) Valor del TIEMPO de las FÍSICAS, para que entre en 'CÁMARA LENTA'. </para>
//    /// </summary>
//    //[Tooltip("(readonly) Valor del TIEMPO de las FÍSICAS, para que entre en 'CÁMARA LENTA'.\n\nNOTA: Cada número corresponde a una DIFICULTAD del JUEGO: inicial <=> FACIL; segundo <=> NORMAL; tercero <=> AVANZADO.")]    
//    private float _miEscalaDeTiempoFixedDeltaTimeCamaraLentaFisicasYFixedUpdates = 0.02f;


//    #region Animacion de Portero

//    /// <summary>
//    /// Variable marca el tiempo maximo para la ANIMACION de GOOOL
//    /// </summary>
//    private readonly float _TIEMPO_MAXIMO_ANIMACION_GOL = 3.0f;

//    /// <summary>
//    /// Variable marca el tiempo maximo para la ANIMACION de GOOOL
//    /// </summary>
//    private readonly float _TIEMPO_MAXIMO_ANIMACION_NO_GOL = 3.0f;

//    /// <summary>
//    /// Variable marca el tiempo maximo para la ANIMACION de GOOOL
//    /// </summary>
//    private readonly float _TIEMPO_DELTA_OFFSET_DETENER_ANIMACION_GOL_Y_NO_GOL = 0.5f;


//    /// <summary>
//    /// Animator (Controller o Controlador de Animaciones) para el Portero controlado por CPU.
//    /// </summary>
//    [Tooltip("Animator (Controller o Controlador de Animaciones) para el Portero controlado por CPU.")]
//    private Animator _miAnimatorPorteroCPU;

//    /// <summary>
//    /// Animator (Controller o Controlador de Animaciones) para el Portero controlado por el Jugador P1.
//    /// </summary>
//    [Tooltip("Animator (Controller o Controlador de Animaciones) para el Portero controlado por el Jugador P1.")]
//    private Animator _miAnimatorPorteroPlayerP1;


//    // Variables para CONTROLAR ANIMACIONES  (ANIMATOR PARAMETERS): 
//    //   Uno por cada 'Animation Clip' o Animacion posible:
//    //
//    /// <summary>
//    /// Nombre en 'Hash' del 'Animation State' de cuando el Personaje-Portero (CPU u Humano Player-P1) está  QUIETO-TRANQUILO in hacer nada (Estado DEFAULT).
//    /// </summary>
//    private static readonly int _PORTERO_IDLE_TRIGGER_PARAMETER_ANIMATION_STATE_HASH = Animator.StringToHash("triggerAnimacionPorteroIdle");

//    // NO Hay GOL  (Parada del Portero  :)

//    /// <summary>
//    /// Nombre en 'Hash' del 'Animation State' de cuando el Personaje-Portero (CPU u Humano Player-P1) DETIENE un GOL: Celebra. RUEDA O SE BALANCEA HACIA LOS LADOS burlonamente.
//    /// </summary>
//    private static readonly int _PORTERO_CELEBRA_RODANDO_TRIGGER_PARAMETER_ANIMATION_STATE_HASH = Animator.StringToHash("triggerAnimacionPorteroCelebraRodando");

//    /// <summary>
//    /// Nombre en 'Hash' del 'Animation State' de cuando el Personaje-Portero (CPU u Humano Player-P1) DETIENE un GOL: Celebra. CRECE como un edificio... mucho. Muestra un Complejo de 'Superioridad' XD.
//    /// </summary>
//    private static readonly int _PORTERO_CELEBRA_CRECIENDO_TRIGGER_PARAMETER_ANIMATION_STATE_HASH = Animator.StringToHash("triggerAnimacionPorteroCelebraCreciendo");

//    // Hay GOOOL!  (Portero TRISTE :(

//    /// <summary>
//    /// Nombre en 'Hash' del 'Animation State' de cuando el Personaje-Portero (CPU u Humano Player-P1) RECIBE un GOOOL: No Celebra. SE LANZA HACIA ATRÁS Y CAE AL PISO, COMO CONDORITO.
//    /// </summary>
//    private static readonly int _PORTERO_NO_CELEBRA_CAEPARAATRAS_TRIGGER_PARAMETER_ANIMATION_STATE_HASH = Animator.StringToHash("triggerAnimacionPorteroNoCelebraCaePaAtras");

//    /// <summary>
//    /// Nombre en 'Hash' del 'Animation State' de cuando el Personaje-Portero (CPU u Humano Player-P1) RECIBE un GOOOL: No Celebra. DECRECE mucho, hasta desaparecer del miedo/verguenza.
//    /// </summary>
//    private static readonly int _PORTERO_NO_CELEBRA_DECRECIENDOHASTADESAPARECER_TRIGGER_PARAMETER_ANIMATION_STATE_HASH = Animator.StringToHash("triggerAnimacionPorteroNoCelebraDecreciendo");

//    /// <summary>
//    /// Nombre en 'Hash' del 'Animation State' de cuando el Personaje-Portero (CPU u Humano Player-P1) RECIBE un GOOOL: No Celebra. COMIENZA A ROTAR HORZONTALMENTE COMO LOCO... Y SE LANZA HACIA ATRÁS Y + CONCATENA CON OTRA ANIMACION: + CAE AL PISO, COMO CONDORITO.
//    /// </summary>
//    private static readonly int _PORTERO_NO_CELEBRA_ROTAHORIZONTAL_TRIGGER_PARAMETER_ANIMATION_STATE_HASH = Animator.StringToHash("triggerAnimacionPorteroNoCelebraRotandoHorizontal");


//    /// <summary>
//    /// Lista de Nombres en 'Hash' de las ANIMACIONES de 'Animation States' de cuando el Personaje-Portero (CPU u Humano Player-P1) RECIBE un GOOOL: No Celebra.
//    /// </summary>
//    private int[] _miListaHashAnimacionesPorteroDeGoool;

//    /// <summary>
//    /// Longitud de Array: Lista de Nombres en 'Hash' de las ANIMACIONES de 'Animation States' de cuando el Personaje-Portero (CPU u Humano Player-P1) RECIBE un GOOOL: No Celebra.
//    /// </summary>
//    private int _miListaHashAnimacionesPorteroDeGoool_Longitud;


//    /// <summary>
//    /// Lista de Nombres en 'Hash' de las ANIMACIONES de 'Animation States' de cuando el Personaje-Portero (CPU u Humano Player-P1) Detiene un Chute: Celebra.
//    /// </summary>
//    private int[] _miListaHashAnimacionesPorteroDeNoGol;

//    /// <summary>
//    /// Longitud de Array: Lista de Nombres en 'Hash' de las ANIMACIONES de 'Animation States' de cuando el Personaje-Portero (CPU u Humano Player-P1) Detiene un Chute: Celebra.
//    /// </summary>
//    private int _miListaHashAnimacionesPorteroDeNoGol_Longitud;

//    #endregion Animacion de Portero

//    #region Animacion de LETRAS DE GOAL, MISS, SAVE

//    /// <summary>
//    /// <para>Clase Interfaz (hacia métodos dentro del ''GameManager.cs'') para Métodos de Animación de las LETRAS 3D (GOAL - 'a favor', y caso de 'Gol en contra' -, MISS y SAVE): Play/Stop Animación, Eventos de Sonido, Imágenes y otros relacionados.</para>
//    /// <para></para>
//    /// <para> NOTA: Se usará dentro del sistema de Animaciones de Mecanim, invocando a cada método mediante EVENTOS colocados dentro del ''Animator'', 
//    ///en la GUI del Editor de Unity3D.</para>
//    /// </summary>
//    [Tooltip("(NOTA: Se agrega automáticamente en 'RunTime', SIEMPRE Y CUANDO haya UN Componente de ése Script dentro de este Objeto 'GameManager'):\n * Clase Interfaz (hacia métodos dentro del ''GameManager.cs'') para Métodos de Animación de las LETRAS 3D (GOAL - 'a favor', y caso de 'Gol en contra' -, MISS y SAVE): Play/Stop Animación, Eventos de Sonido, Imágenes y otros relacionados.")]
//    public AnimacionesLetrasEnPantalla _miScriptAnimacionesLetrasEnPantalla;

//    #endregion Animacion de LETRAS DE GOAL, MISS, SAVE

//    #region Camara y Animaciones

//    /// <summary>
//    /// El Juego podría ternimar si el Jugador hace GOL (o si FALLA), en este turno que viene? (readonly). CUÁL ES EL JUGADOR QUE GANARÍA, EN ESE CASO??
//    /// </summary>
//    [Tooltip("El Juego podría ternimar si el Jugador hace GOL (o si FALLA), en este turno que viene? (readonly). CUÁL ES EL JUGADOR QUE GANARÍA, EN ESE CASO??")]
//    public _JUGADORES _nombreDeJugadorQuePodriaGanarEnSiguienteTurno = _JUGADORES.NINGUNO;

//    /// <summary>
//    /// Camara REAL del Juego (la verdadera cámara, la de A.R. de Vuforia, motor de X.R.).
//    /// </summary>
//    [Tooltip("Camara REAL del Juego (la verdadera cámara, la de A.R. de Vuforia, motor de X.R.).")]
//    public Camera _miCamaraRealDeLaApp;

//    /// <summary>
//    /// Camara aparente del Juego (porque la verdadera cámara será la de A.R. de Vuforia, motor de X.R.).
//    /// </summary>
//    [Tooltip("Camara aparente del Juego (porque la verdadera cámara será la de A.R. de Vuforia, motor de X.R.).")]
//    public /* Camera */ GameObject _miCamaraAparente;

//    /// <summary>
//    /// Script para mover la Camara del Juego en dirección: hacia el Portero (para poder PORTEAR).
//    /// </summary>
//    //[Tooltip("Script para mover la Camara del Juego en dirección: hacia el Portero (para poder PORTEAR)")]
//    [HideInInspector]
//    public CamaraEnfocarUnPuntoYMoverseADestino _miScriptCamaraEnfocarUnPuntoYMoverseADestinoPortear;

//    /// <summary>
//    /// Script para mover la Camara del Juego en dirección: hacia el Chutador del Penalty (para poder Cobrar el Penalty).
//    /// </summary>
//    //[Tooltip("Script para mover la Camara del Juego en dirección: hacia el Chutador del Penalty (para poder Cobrar el Penalty).")]
//    [HideInInspector]
//    public CamaraEnfocarUnPuntoYMoverseADestino _miScriptCamaraEnfocarUnPuntoYMoverseADestinoChutar;

//    /// <summary>
//    /// Script para mover la Camara del Juego a manera de ANIMACION:  cuando se entra a PELIGRO, a punto de terminar el Partido.
//    /// </summary>
//    //[Tooltip("Script para mover la Camara del Juego a manera de ANIMACION:  cuando se entra a PELIGRO, a punto de terminar el Partido.")]
//    [HideInInspector]
//    public CamaraEnfocarMuchosPuntosYMoverseAMuchosDestinos _miScriptCamaraParaAnimacionDePeligroEnfocarMuchosPuntosYMoverseAMuchosDestinos;

//    /// <summary>
//    /// Script para mover la Camara del Juego durante animación de GOOOL y NO-GOL.
//    /// </summary>
//    //[Tooltip("Script para mover la Camara del Juego durante animación de GOOOL y NO-GOL.")]
//    [HideInInspector]
//    public CamaraEnfocarMuchosPuntosYMoverseAMuchosDestinos _miScriptCamaraParaAnimacionDeGolOSalvadaEnfocarMuchosPuntosYMoverseAMuchosDestinos;

//    /// <summary>
//    /// Script para mover la Camara del Juego durante animación de FIN DE JUEGO: ''GANAR'' o ''PERDER''.
//    /// </summary>
//    //[Tooltip("Script para mover la Camara del Juego durante animación de FIN DE JUEGO: ''GANAR'' o ''PERDER''.")]
//    [HideInInspector]
//    public CamaraEnfocarMuchosPuntosYMoverseAMuchosDestinos _miScriptCamaraParaAnimacionAlGanarOPerderEnfocarMuchosPuntosYMoverseAMuchosDestinos;

//    /// <summary>
//    /// Script para mover (ROTAR ANTIHORARIO, VISIÓN PANORÁMICA) la Camara del Juego durante animación de FIN DE JUEGO: ''GANAR'' o ''PERDER''.
//    /// </summary>
//    //[Tooltip("Script para mover (ROTAR ANTIHORARIO, VISIÓN PANORÁMICA) la Camara del Juego durante animación de FIN DE JUEGO: ''GANAR'' o ''PERDER''.")]
//    [HideInInspector]
//    public Rotate _miScriptCamaraParaAnimacionAlGanarOPerderRotacionPanoramicaAlrededorDelMundo;

//    #endregion Camara y Animaciones

//    #endregion Variables de Animaciones


//    #region Musica y Sonidos

////    /// <summary>
////    /// Musica de Background (fondo)
////    /// </summary>
////    [Tooltip("Musica de Background (fondo)")]
////    public AudioSource _miMusicaBackground;

//    #region Musica

////    /// <summary>
////    /// Musica de Background (fondo). Se activará sólo cuando aparezca el GAME OVER: WIN o LOSE. Será el mismo que:   '_miAudioSourceBullaGritosHumanosNormalConstante'
////    /// </summary>
////    //[Tooltip("Musica de Background (fondo).\n Se activará sólo cuando aparezca el GAME OVER: WIN o LOSE. \nSerá el mismo que:   '_miAudioSourceBullaGritosHumanosNormalConstante'")]
////    private AudioSource _miMusicaBackgroundGameOver;     // Será el mismo que:   '_miAudioSourceBullaGritosHumanosNormalConstante'

//    //...El CANAL DE MÚSICA será: el mismo que:   '_miAudioSourceBullaGritosHumanosNormalConstante'

//    /// <summary>
//    /// MÚSICA de GAMEOVER (Archivo (.ogg o .mp3)): El Tema Principal del Juego!
//    /// </summary>
//    [Tooltip("MÚSICA de GAMEOVER (Archivo (.ogg o .mp3)): \nEl Tema Principal del Juego!")]
//    public AudioClip _miMusicClipMusicaBackgroundGameOver;

//    #endregion Musica


//    #region Sonidos
//    //SFX:

//    #region Silbatazos

//    /// <summary>
//    /// Fuente del Audio: Silbatazo.
//    /// </summary>
//    //[Tooltip("Fuente del Audio: Silbatazo.")]
//    [HideInInspector]
//    public AudioSource _miAudioSourceSilbatazos;

////    /// <summary>
////    /// Lista de: Sonidos de Silbato para poder cobrar el penalty, grupo para seleccionar uno aleatoriamente.
////    /// </summary>
////    [Tooltip("Lista de: Sonidos de Silbato para poder cobrar el penalty, grupo para seleccionar uno aleatoriamente.")]
////    public AudioClip[] _miListaSonidosSilbatazosCobrarPenalty;

//    /// <summary>
//    /// Sonido de Silbato para poder cobrar el penalty.
//    /// </summary>
//    [Tooltip("Sonido de Silbato para poder cobrar el penalty.")]
//    public AudioClip _miSonidoSilbatazoCobrarPenalty;

//    #endregion Silbatazos


//    #region Sonidos de Animaciones (GameObject: Portero)

//    /// <summary>
//    /// Fuente del Audio: Animaciones (GameObject: Portero).
//    /// </summary>
//    //[Tooltip("Fuente del Audio: Animaciones (GameObject: Portero).")]
//    [HideInInspector]
//    public AudioSource _miAudioSourceAnimacionesDelPortero;

//    /// <summary>
//    /// Sonido de Animacion (GameObject: Portero): Evitar un GOL: Bailar.
//    /// </summary>
//    [Tooltip("Sonido de Animacione (GameObject: Portero): Evitar un GOL: Bailar.")]
//    public AudioClip _miSonidoDeAnimacionDePortero_BailarComoBigSalad;

//    /// <summary>
//    /// Sonido de Animacion (GameObject: Portero): Evitar un GOL: Crecer muuucho como edificio.
//    /// </summary>
//    [Tooltip("Sonido de Animacion (GameObject: Portero): Evitar un GOL: Crecer muuucho como edificio.")]
//    public AudioClip _miSonidoDeAnimacionDePortero_CrecerMuchoComoEdificio;

//    /// <summary>
//    /// Sonido de Animacion (GameObject: Portero): Recibir un GOL: Caer para atrás: PLOP.
//    /// </summary>
//    [Tooltip("Sonido de Animacion (GameObject: Portero): Recibir un GOL: Caer para atrás: PLOP.")]
//    public AudioClip _miSonidoDeAnimacionDePortero_CaerParaAtrasPLOP;

//    /// <summary>
//    /// Sonido de Animacion (GameObject: Portero): Recibir un GOL: Rotar Horizontalmente.
//    /// </summary>
//    [Tooltip("Sonido de Animacion (GameObject: Portero): Recibir un GOL: Rotar Horizontalmente.")]
//    public AudioClip _miSonidoDeAnimacionDePortero_RotarHorizontalmente;

//    /// <summary>
//    /// Sonido de Animacion (GameObject: Portero): Recibir un GOL: Hacerse chiquitico... hasta desaparecer.
//    /// </summary>
//    [Tooltip("Sonido de Animacion (GameObject: Portero): Recibir un GOL: Hacerse chiquitico... hasta desaparecer.")]
//    public AudioClip _miSonidoDeAnimacionDePortero_HacerseChiquiticoHastaDesaparecer;

//    #endregion Sonidos de Animaciones (GameObject: Portero)


//    #region Sonidos de BALONAZO e interaccion BALON-OBJETOS

//    /// <summary>
//    /// Lista de: Sonidos de 'Patada-Balon'.
//    /// </summary>
//    [Tooltip("Lista de: Sonidos de 'Patada-Balon'.")]
//    public AudioClip[] _miListaSonidosBalonPatada;

//    /// <summary>
//    /// Longitud de: Lista de: Sonidos de 'Patada-Balon'.
//    /// </summary>
//    //[Tooltip("Longitud de: Lista de: Sonidos de 'Patada-Balon'.")]
//    [HideInInspector]
//    public int _miListaSonidosBalonPatada_Longitud;


//    /// <summary>
//    /// Lista de: Sonidos de Colisión: BALON-POSTE de metal (de la Portería).
//    /// </summary>
//    [Tooltip("Lista de: Sonidos de Colisión: BALON-POSTE de metal (de la Portería).")]
//    public AudioClip[] _miListaSonidosBalonColisionConPostePorteria;

//    /// <summary>
//    /// Longitud de: Lista de: Sonidos de Colisión: BALON-POSTE de metal (de la Portería).
//    /// </summary>
//    //[Tooltip("Lista de: Sonidos de Colisión: BALON-POSTE de metal (de la Portería).")]
//    [HideInInspector]
//    public int _miListaSonidosBalonColisionConPostePorteria_Longitud;


//    /// <summary>
//    /// Lista de: Sonidos de Colisión: BALON-MANO DE PORTERO.
//    /// </summary>
//    [Tooltip("Lista de: Sonidos de Colisión: BALON-MANO DE PORTERO.")]
//    public AudioClip[] _miListaSonidosBalonColisionConManosDePortero;

//    /// <summary>
//    /// Longitud de: Lista de: Sonidos de Colisión: BALON-MANO DE PORTERO.
//    /// </summary>
//    //[Tooltip("Longitud de: Lista de: Sonidos de Colisión: BALON-MANO DE PORTERO.")]
//    [HideInInspector]
//    public int _miListaSonidosBalonColisionConManosDePortero_Longitud;


//    // No implementado:
////    /// <summary>
////    /// Lista de: Arrastre del Balon por el suelo de concreto.
////    /// </summary>
////    [Tooltip("Lista de: Arrastre del Balon por el suelo de concreto")]
////    public AudioClip[] _miListaSonidosBalonArrastrePorSueloConcreto;


//    #endregion Sonidos de BALONAZO e interaccion BALON-OBJETOS


//    #region Sonidos de Fondo

//    #region Gritos humanos: Bulla

//    /// <summary>
//    /// Fuente del Audio: Bulla de Público General, constante y presente estilo fondo músical (O_o).
//    /// </summary>
//    //[Tooltip("Fuente del Audio: Bulla de Público General, constante y presente estilo fondo músical (O_o).")]
//    [HideInInspector]
//    public AudioSource _miAudioSourceBullaGritosHumanosNormalConstante;

//    /// <summary>
//    /// Sonido de 'Gritos humanos' o Bulla a nivel de volumen normal.
//    /// </summary>
//    [Tooltip("Sonido de 'Gritos humanos' o Bulla a nivel de volumen normal.")]
//    public AudioClip _miSonidoBullaGritosHumanosNormalConstante;


//    /// <summary>
//    /// Fuente del Audio: Bulla de Piblico al haber un Chute (Gol o No-Gol).
//    /// </summary>
//    //[Tooltip("Fuente del Audio: Bulla de Piblico al haber un Chute (Gol o No-Gol).")]
//    [HideInInspector]
//    public AudioSource _miAudioSourceBullaPublicoEmocionGol;

//    /// <summary>
//    /// Lista de: Sonidos de 'Bulla de GOOOL' (muy intensa).
//    /// </summary>
//    [Tooltip("Lista de: Sonidos de 'Bulla de GOOOL' (muy intensa).")]
//    public AudioClip[] _miListaSonidosBullaDeGOOOL;

//    /// <summary>
//    /// Longitud de: Lista de: Sonidos de 'Bulla de GOOOL' (muy intensa).
//    /// </summary>
//    //[Tooltip("Lista de: Sonidos de 'Bulla de GOOOL' (muy intensa).")]
//    [HideInInspector]
//    public int _miListaSonidosBullaDeGOOOL_Longitud;


//    /// <summary>
//    /// Lista de: Sonidos de 'Bulla de FALLAR EL GOL' (ABUCHEO).
//    /// </summary>
//    [Tooltip("Lista de: Sonidos de 'Bulla de FALLAR EL GOL' (ABUCHEO).")]
//    public AudioClip[] _miListaSonidosBullaDeFallarElGOOOLAbucheo;

//    /// <summary>
//    /// Longitud de: Lista de: Sonidos de 'Bulla de FALLAR EL GOL' (ABUCHEO).
//    /// </summary>
//    //[Tooltip("Lista de: Sonidos de 'Bulla de FALLAR EL GOL' (ABUCHEO).")]
//    [HideInInspector]
//    public int _miListaSonidosBullaDeFallarElGOOOLAbucheo_Longitud;

//    #endregion Gritos humanos: Bulla

//    #endregion Sonidos de Fondo


//    #region Comentarios

//    /// <summary>
//    /// Fuente del Audio de: Voz del Comentarista.
//    /// </summary>
//    //[Tooltip("Fuente del Audio de: Voz del Comentarista.")]
//    [HideInInspector]
//    public AudioSource _miAudioSourceComentarista;

//    /// <summary>
//    /// Los Sonidos de GRITO DE COMENTARISTA DE GOOOL, grupo para seleccionar uno aleatoriamente.
//    /// </summary>
//    [Tooltip("Los Sonidos de GRITO DE COMENTARISTA DE GOOOL, grupo para seleccionar uno aleatoriamente.")]
//    public AudioClip[] _miListaDeSonidosComentarioDeGol;

//    /// <summary>
//    /// Longitud del Array: Los Sonidos de GRITO DE COMENTARISTA DE GOOOL, grupo para seleccionar uno aleatoriamente.
//    /// </summary>
//    //[Tooltip("Longitud del Array: Los Sonidos de GRITO DE COMENTARISTA DE GOOOL, grupo para seleccionar uno aleatoriamente.")]
//    [HideInInspector]
//    public int _miListaDeSonidosComentarioDeGol_Longitud;


//    /// <summary>
//    /// Los Sonidos de GRITO DE COMENTARISTA DE NO-GOL, grupo para seleccionar uno aleatoriamente.
//    /// </summary>
//    [Tooltip("Los Sonidos de GRITO DE COMENTARISTA DE NO-GOL, grupo para seleccionar uno aleatoriamente.")]
//    public AudioClip[] _miListaDeSonidosComentarioDeNoGol;

//    /// <summary>
//    /// Longitud del Array: Los Sonidos de GRITO DE COMENTARISTA DE NO-GOL, grupo para seleccionar uno aleatoriamente.
//    /// </summary>
//    //[Tooltip("Longitud del Array: Los Sonidos de GRITO DE COMENTARISTA DE NO-GOL, grupo para seleccionar uno aleatoriamente.
//    [HideInInspector]
//    public int _miListaDeSonidosComentarioDeNoGol_Longitud;


//    /// <summary>
//    /// Los Sonidos de Comentarios al Chutador (elogios a su chute-y-GOL), grupo para seleccionar uno aleatoriamente.
//    /// </summary>
//    [Tooltip("Los Sonidos de Comentarios al Chutador (elogios a su chute-y-GOL), grupo para seleccionar uno aleatoriamente.")]
//    public AudioClip[] _miListaDeSonidosComentariosAlChutadorGol;

//    /// <summary>
//    /// Longitud del Array: Los Sonidos de Comentarios al Chutador (elogios a su chute-y-GOL), grupo para seleccionar uno aleatoriamente.
//    /// </summary>
//    //[Tooltip("Longitud del Array: Los Sonidos de Comentarios al Chutador (elogios a su chute-y-GOL), grupo para seleccionar uno aleatoriamente.")]
//    [HideInInspector]
//    public int _miListaDeSonidosComentariosAlChutadorGol_Longitud;


//    /// <summary>
//    /// Los Sonidos de Comentarios cuando el 'Player' se equivoca. \nPor ejemplo: si es CHUTADOR: (críticas destructivas a su chute-y-NO-GOL).\nSi es Portero: serán críticas por fallar al tratar de tapar el Gol. \nGrupo para seleccionar uno aleatoriamente.
//    /// </summary>
//    [Tooltip("Los Sonidos de Comentarios cuando el 'Player' se equivoca. \nPor ejemplo: si es CHUTADOR: (críticas destructivas a su chute-y-NO-GOL).\nSi es Portero: serán críticas por fallar al tratar de tapar el Gol. \nGrupo para seleccionar uno aleatoriamente.")]
//    public AudioClip[] _miListaDeSonidosComentariosDestructivosChutadorOPortero;

//    /// <summary>
//    /// Longitud del Array: Los Sonidos de Comentarios cuando el 'Player' se equivoca. \nPor ejemplo: si es CHUTADOR: (críticas destructivas a su chute-y-NO-GOL).\nSi es Portero: serán críticas por fallar al tratar de tapar el Gol. \nGrupo para seleccionar uno aleatoriamente.
//    /// </summary>
//    //[Tooltip("Longitud del Array: Los Sonidos de Comentarios cuando el 'Player' se equivoca. \nPor ejemplo: si es CHUTADOR: (críticas destructivas a su chute-y-NO-GOL).\nSi es Portero: serán críticas por fallar al tratar de tapar el Gol. \nGrupo para seleccionar uno aleatoriamente.")]
//    [HideInInspector]
//    public int _miListaDeSonidosComentariosDestructivosChutadorOPortero_Longitud;


//    /// <summary>
//    /// Los Sonidos de Comentarios de SALVADA EXITOSA DEL PORTERO, grupo para seleccionar uno aleatoriamente.
//    /// </summary>
//    [Tooltip("Los Sonidos de Comentarios de SALVADA EXITOSA DEL PORTERO, grupo para seleccionar uno aleatoriamente.")]
//    public AudioClip[] _miListaDeSonidosComentariosAlPorteroSalvadaExitosa;

//    /// <summary>
//    /// Longitud de: Los Sonidos de Comentarios de SALVADA EXITOSA DEL PORTERO, grupo para seleccionar uno aleatoriamente.
//    /// </summary>
//    //[Tooltip("Longitud de: Los Sonidos de Comentarios de SALVADA EXITOSA DEL PORTERO, grupo para seleccionar uno aleatoriamente.")]
//    [HideInInspector]
//    public int _miListaDeSonidosComentariosAlPorteroSalvadaExitosa_Longitud;


//    // No implementado, sino más arriba cJUNTO con el CASO: CHUTADOR EXITOSO.
////    /// <summary>
////    /// Los Sonidos de Comentarios de PORTERO FALLA (y hay GOL), grupo para seleccionar uno aleatoriamente.
////    /// </summary>
////    [Tooltip("Los Sonidos de Comentarios de PORTERO FALLA (y hay GOL), grupo para seleccionar uno aleatoriamente.")]
////    public AudioClip[] _miListaDeSonidosComentariosAlPorteroFallaYHayGol;

//    /// <summary>
//    /// Variable para reproducir el Sonido de GOL una sola vez por chute.
//    /// </summary>
//    [Tooltip("Variable para reproducir el Sonido de GOL una sola vez por chute.")]
//    public bool _faltaReproducirSonidoDeGol = true;


//    /// <summary>
//    /// Los Sonidos de Comentarios al GANAR, al final.
//    /// </summary>
//    [Tooltip("Los Sonidos de Comentarios al GANAR, al final.")]
//    public AudioClip[] _miListaDeSonidosComentariosAlFinalAlGanar;

//    /// <summary>
//    /// Longitud de: Los Sonidos de Comentarios al GANAR, al final.
//    /// </summary>
//    [Tooltip("Longitud de: Los Sonidos de Comentarios al GANAR, al final.")]
//    public int _miListaDeSonidosComentariosAlFinalAlGanar_Longitud;


//    /// <summary>
//    /// Los Sonidos de Comentarios al PERDER, al final.
//    /// </summary>
//    [Tooltip("Los Sonidos de Comentarios al PERDER, al final.")]
//    public AudioClip[] _miListaDeSonidosComentariosAlFinalAlPerder;

//    /// <summary>
//    /// Longitud de: Los Sonidos de Comentarios al PERDER, al final.
//    /// </summary>
//    //[Tooltip("Longitud de: Los Sonidos de Comentarios al PERDER, al final.")]
//    [HideInInspector]
//    public int _miListaDeSonidosComentariosAlFinalAlPerder_Longitud;


//    /// <summary>
//    /// Variable para reproducir el Sonido de GANAR O PERDER, al final.
//    /// </summary>
//    [Tooltip("Variable para reproducir el Sonido de GANAR O PERDER, al final.")]
//    public bool _faltaReproducirSonidoAlFinalDeGanarOPerder = true;


//    /// <summary>
//    /// Los Sonidos de Comentarios de cuando el juego está en PELIGRO de TERMINAR (por un Gol, o una Fallada).
//    /// </summary>
//    [Tooltip("Los Sonidos de Comentarios de cuando el juego está en PELIGRO de TERMINAR (por un Gol, o una Fallada).")]
//    public AudioClip[] _miListaDeSonidosComentariosCuandoJuegoEstaEnPeligroDeTerminar;

//    /// <summary>
//    /// Longitud de: Los Sonidos de Comentarios de cuando el juego está en PELIGRO de TERMINAR (por un Gol, o una Fallada).
//    /// </summary>
//    //[Tooltip("Longitud de: Los Sonidos de Comentarios de cuando el juego está en PELIGRO de TERMINAR (por un Gol, o una Fallada).")]
//    [HideInInspector]
//    public int _miListaDeSonidosComentariosCuandoJuegoEstaEnPeligroDeTerminar_Longitud;


//    /// <summary>
//    /// Variable para reproducir el Sonido de cuando el juego está en PELIGRO de TERMINAR (por un Gol, o una Fallada).
//    /// </summary>
//    [Tooltip("Variable para reproducir el Sonido de cuando el juego está en PELIGRO de TERMINAR (por un Gol, o una Fallada).")]
//    public bool _faltaReproducirSonidoComentarioCuandoJuegoEstaEnPeligroDeTerminar = true;


//    /// <summary>
//    /// Los Sonidos de Comentarios al entrar en FASE de "Sudden Death".
//    /// </summary>
//    [Tooltip("Los Sonidos de Comentarios al entrar en FASE de 'Sudden Death'.")]
//    public AudioClip[] _miListaDeSonidosComentariosAlEntrarEnFaseDeSuddenDeath;

//    /// <summary>
//    /// Longitud de: Los Sonidos de Comentarios al entrar en FASE de "Sudden Death".
//    /// </summary>
//    //[Tooltip("Longitud de: Los Sonidos de Comentarios al entrar en FASE de 'Sudden Death'.")]
//    [HideInInspector]
//    public int _miListaDeSonidosComentariosAlEntrarEnFaseDeSuddenDeath_Longitud;


//    /// <summary>
//    /// Los Sonidos de Comentarios en forma de error/Bloopers al entrar en FASE de "Sudden Death".
//    /// </summary>
//    [Tooltip("Los Sonidos de Comentarios en forma de error/Bloopers al entrar en FASE de 'Sudden Death'.")]
//    /// <summary>
//    /// Antes: public AudioClip[] _miListaDeSonidosComentarios_Bloopers_AlEntrarEnFaseDeSuddenDeath;    /// </summary>
//    public AudioClip _miSonidoComentario_Blooper_AlEntrarEnFaseDeSuddenDeath;

//    /// <summary>
//    /// PORCENTAJE (de 0 a 1.0) de Probabilidad de Reproducir un Audio Blooper de Comentario al entrar en FASE de "Sudden Death".
//    /// De todas maneras no es determinante, ya que este PORCENTAJE SOLO evalúa cuando el JUGADOR P1 entra en SUDDEN DEATH de 'manera EXITOSA': mediante un GOL (siendo el TIRADOR) o por una PARADA (siendo PORTERO).
//    /// </summary>
//    [Tooltip("PORCENTAJE (de 0 a 1.0) de Probabilidad de Reproducir un Audio Blooper de Comentario al entrar en FASE de 'Sudden Death'. De todas maneras no es determinante, ya que este PORCENTAJE SOLO evalúa cuando el JUGADOR P1 entra en SUDDEN DEATH de 'manera EXITOSA': mediante un GOL (siendo el TIRADOR) o por una PARADA (siendo PORTERO).")]
//    [Range(0.0f, 1.0f)]
//    public float _miProbabilidadDeReproducirUnBlooperDeSuddenDeath = 0.5f;  // 50 % POR CIENTO = 0.5f;

//    /// <summary>
//    /// Variable para reproducir el Sonido de cuando se entra a FASE de "Sudden Death".
//    /// </summary>
//    [Tooltip("Variable para reproducir el Sonido de cuando se entra a FASE de 'Sudden Death'.")]
//    public bool _faltaReproducirSonidoComentariosAlEntrarEnFaseDeSuddenDeath = true;


//    #endregion Comentarios

////    #region Fuegos Artificiales Ganador
////
////    /// <summary>
////    /// Fuente del Audio: Canal 1 de Fuegos Artificiales.
////    /// </summary>
////    //[Tooltip("Fuente del Audio: Canal 1 de Fuegos Artificiales.")]
////    [HideInInspector]
////    public AudioSource _miAudioSourceFuegosArtificiales_1;
////
////
////    #endregion Fuegos Artificiales Ganador


////	public AudioClip gameOverSFX;

////	[Tooltip("Only need to set if canBeatLevel is set to true.")]
////	public AudioClip beatLevelSFX;

//    #endregion Sonidos

//    #endregion Musica y Sonidos


//    #region Sombras Dinamicas

//    /// <summary>
//    /// (Ojo: Puede ser NULL, sin problemas se inicializará en este Script) Sombras Dinamicas hechas por mí, para no usar el REALTIME LIGHTING  de Unity3d, por ser muy 'gastador'.
//    /// </summary>
//    [Tooltip("(Ojo: Puede ser NULL, sin problemas se inicializará en este Script) Sombras Dinamicas hechas por mí, para no usar el REALTIME LIGHTING  de Unity3d, por ser muy 'gastador'.")]
//    public ShadowsDynamicManager _miScriptShadowsDynamicManager;

//    // Objectos Sombras:

//    /// <summary>
//    /// Sombra del BALÓN (Dinamica hecha por mí, para no usar el REALTIME LIGHTING  de Unity3d, por ser muy 'gastador').
//    /// </summary>
//    [Tooltip("Sombra del BALÓN (Dinamica hecha por mí, para no usar el REALTIME LIGHTING  de Unity3d, por ser muy 'gastador').")]
//    public GameObject _miSombraDelBalon;

//    /// <summary>
//    /// Sombra del PORTERO P1 (Dinamica hecha por mí, para no usar el REALTIME LIGHTING  de Unity3d, por ser muy 'gastador').
//    /// </summary>
//    [Tooltip("Sombra del PORTERO P1 (Dinamica hecha por mí, para no usar el REALTIME LIGHTING  de Unity3d, por ser muy 'gastador').")]
//    public GameObject _miSombraDelPorteroP1;

//    /// <summary>
//    /// Sombra del PORTERO CPU (Dinamica hecha por mí, para no usar el REALTIME LIGHTING  de Unity3d, por ser muy 'gastador').
//    /// </summary>
//    [Tooltip("Sombra del PORTERO CPU (Dinamica hecha por mí, para no usar el REALTIME LIGHTING  de Unity3d, por ser muy 'gastador').")]
//    public GameObject _miSombraDelPorteroCPU;

//    // Hardcoded LOS INDICES DE LOS ARRAY:
//    // NOTA: OJO!!!!!!!!: DEBEN seguir el MISMO ORDEN de los OBJECTOS DE ARRIBA - SOMBRAS!!::::::

//    /// <summary>
//    /// CONSTANTE para los ARRAY: 1- HEROES y  2- SOMBRAS: Indice de BALON
//    /// </summary>
//    public const int _MI_INDICE_SOMBRA_DIN_BALON = 0;

//    /// <summary>
//    /// CONSTANTE para los ARRAY: 1- HEROES y  2- SOMBRAS: Indice de PORTERO (PLAYER) P1
//    /// </summary>
//    public const int _MI_INDICE_SOMBRA_DIN_PORTERO_P1 = 1;

//    /// <summary>
//    /// CONSTANTE para los ARRAY: 1- HEROES y  2- SOMBRAS: Indice de PORTERO CPU
//    /// </summary>
//    public const int _MI_INDICE_SOMBRA_DIN_PORTERO_CPU = 2;

//    //...

//    // Longitud de todos los ARRAY:

//    /// <summary>
//    /// Longitud de ARRAYs:
//    /// </summary>
//    public const int _MI_NUMERO_DE_HEROES_CON_SOMBRA_DINAMICA = 3;

//    #endregion Sombras Dinamicas


//    #region Efectos Visuales

//    /// <summary>
//    /// (Ojo: Puede ser NULL, sin problemas se inicializará en este Script) Efecto Visual (clase 'UnityStandardAssets.ImageEffects') de PANTALLA DE COLOR GRIS.
//    /// </summary>
//    [Tooltip("(Ojo: Puede ser NULL, sin problemas se inicializará en este Script) Efecto Visual (clase 'UnityStandardAssets.ImageEffects') de PANTALLA DE COLOR GRIS.")]
//    public Grayscale _miScriptEfectoGrayscale;

//    #endregion Efectos Visuales


//    #region Utility y Miscelaneos

//    #region Garbage Collection

//    /// <summary>
//    /// GarbageCollectionManager
//    /// Mi Clase que es un CONTENEDOR DE MÉTODOS para la Limpieza de la Basura (Garbage Collection), generada por VUFORIA Pricipalmente (el NameSpace VuforiaBehaviour genera muchos GC.Alloc).
//    /// No es del Tipo MonoBehaviour, es decir, nada de: UPDATE, AWAKE, GetComponent... todo eso se hará en el GameManager, y si hace falta: se suscribirá a esos métodos al GameManager 
//    /// TODO (aún tengo que Googlear cómo hacer eso).
//    /// </summary>
//    [Tooltip("GarbageCollectionManager \nMi Clase que es un CONTENEDOR DE MÉTODOS para la Limpieza de la Basura (Garbage Collection), generada por VUFORIA Pricipalmente (el NameSpace VuforiaBehaviour genera muchos GC.Alloc). \nNo es del Tipo MonoBehaviour, es decir, nada de: UPDATE, AWAKE, GetComponent... todo eso se hará en el GameManager, \ny si hace falta: se suscribirá a esos métodos al GameManager (aún tengo que Googlear cómo hacer eso).")]
//    public static GarbageCollectionManager _miGarbageCollectionManager;

//    /// <summary>
//    /// (readonly) Heap de Memoria o Garbage / Basura actual. Recomendado: Limpia si es mayor a 27 MB (27.000.000 KB)
//    /// </summary>
//    [Tooltip("(readonly) Heap de Memoria o Garbage / Basura actual. Recomendado: Limpia si es mayor a 27 MB (27.000.000 KB)")]
//    public long _miMemoriaHeapGarbageActual = 0;


//    /// <summary>
//    /// Variable que dice si el JUEGO esta en un MOMENTO en que es posible activar el GC.Collect() para Limpiar la Garbage de la Memoria: sin afectar negativamente el PERFORMANCE mucho...
//    /// </summary>
//    public bool _puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance = false;


//    ///// <summary>
//    ///// Variable que dice si está activada la LIMPIEZA cada cierto tiempo en alguna clase con UPDATE... (pudiendo estar o no encendido el GARBAGE COLLECTOR AUTOMÁTICO NORMAL POR DEFAULT)
//    ///// </summary>
//    //[Tooltip("Variable que dice si está activada la LIMPIEZA cada cierto tiempo en alguna clase con UPDATE... (pudiendo estar o no encendido el GARBAGE COLLECTOR AUTOMÁTICO NORMAL POR DEFAULT)")]
//    //public bool _estaActivadoLimpiezaCadaNSegundosManual = true;


//    /// <summary>
//    /// Constante que define el Tamano mínimo del HEAP PERMITIDO antes de ejecutar una limpieza, i.e. llamada a GC.Collect()
//    /// </summary>
//    public const long _TAMANO_HEAP_GARBAGE_MINIMO_BYTES = 27000000; //50000000;


//    /// <summary>
//    /// Constante que define el Tamano máximo (ESTADO DE EMERGENCIA!) del HEAP PERMITIDO antes de ejecutar una limpieza, i.e. llamada a GC.Collect()
//    /// </summary>
//    public const long _TAMANO_HEAP_GARBAGE_MAXIMO_EMERGENCIA_BYTES = 43000000; //50000000;

//    /// <summary>
//    /// Variable que cuenta el tiempo transcurrido entre invocaciones a: System.GC.Collect.
//    /// </summary>
//    [Tooltip("Variable que cuenta el tiempo transcurrido entre invocaciones a: System.GC.Collect.")]
//    public float _miTiempoParaInvocarGCCollect = 0.0f;


//    /// <summary>
//    /// CONSTANTE DE TIEMPO MÍNIMA para definir CUÁNDO se Realizará un GC.Collect()
//    /// </summary>
//    [Tooltip("CONSTANTE DE TIEMPO MÍNIMA para definir CUÁNDO se Realizará un GC.Collect()")]
//    public const float _CONSTANTE_TIEMPO_MINIMA_N_SEGUNDOS_PUEDE_INVOCAR_GC_COLLECT = 96.0f; // Basado en Proporcion aurea: 4.8f;   // 12.0f;   // 10.0f

//    /// <summary>
//    /// CONSTANTE DE TIEMPO MÁXIMA para definir CADA CUÁNTO se Realizará un GC.Collect()
//    /// </summary>
//    [Tooltip("CONSTANTE DE TIEMPO MÁXIMA para definir CADA CUÁNTO se Realizará un GC.Collect(), INCLUSO FORZADO COMO EMERGENCIA")]
//    public const float _CONSTANTE_TIEMPO_MAXIMO_EMERGENCIA_N_SEGUNDOS_INVOCAR_GC_COLLECT = 150.45f;  //96.0f;   // 150.45f para 43.69 MB;    // 180.0f;

//    /// <summary>
//    /// CONSTANTE DE TIEMPO MÍNIMA para POSTPONER la LIMPIEZA DE GARBAGE HEAP (i.e.: GC.Collect()), cuando se encuentra en un MAL MOMENTO (de PERFORMANCE CRÍTICO).
//    /// </summary>
//    [Tooltip("CONSTANTE DE TIEMPO MÍNIMA para POSTPONER la LIMPIEZA DE GARBAGE HEAP (i.e.: GC.Collect()), cuando se encuentra en un MAL MOMENTO (de PERFORMANCE CRÍTICO).")]
//    public const float _CONSTANTE_TIEMPO_MINIMA_N_SEGUNDOS_POSPONER_UN_POCO_INVOCACION_A_GC_COLLECT = _CONSTANTE_TIEMPO_MINIMA_N_SEGUNDOS_PUEDE_INVOCAR_GC_COLLECT - 5.41f;  //5.41f; // Basado en Proporcion aurea: // 5.41f; // 8.75f;  // 14.0f


//    /// <summary>
//    /// Variable de NUMEROS para usar: no generar GARBAGE COLLECTION, al realizar una conversion estilo Int32 'ToString()'...
//    /// ..Cada NUMERO equivale a CASILLA. Empieza desde Cero; termina en 20
//    /// </summary>
//    [Tooltip("Variable de NUMEROS para usar: no generar GARBAGE COLLECTION, al realizar una conversion estilo Int32 'ToString()'...\n..Cada NUMERO equivale a CASILLA. Empieza desde Cero; termina en 20")]
//    private static readonly string[] _NUMEROS_STRING_LIMITE_20 = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" };

//    /// <summary>
//    /// Longitud MÁXIMA a usar de: ""_NUMEROS_STRING_LIMITE_20"" (i.e.: Variable de NUMEROS para usar: no generar GARBAGE COLLECTION, al realizar una conversion estilo Int32 'ToString()'... \n..Cada NUMERO equivale a CASILLA. Empieza desde Cero; termina en 20
//    /// </summary>
//    [Tooltip("Longitud MÁXIMA a usar de: ''_NUMEROS_STRING_LIMITE_20'' (i.e.: Variable de NUMEROS para usar: no generar GARBAGE COLLECTION, al realizar una conversion estilo Int32 'ToString()'...\n..Cada NUMERO equivale a CASILLA. Empieza desde Cero; termina en 20.)")]
//    private static readonly int _LENGTH_DE_NUMEROS_STRING_LIMITE_20 = 20;

//    #endregion Garbage Collection


//    /// <summary>
//    /// Quiere que los //DEBUG.LOG(), .WARNING() Y .ERROR() se generen y vean en el LogCat() de Android, o su Dispositivo?
//    /// </summary>
//    [Tooltip("Quiere que los //DEBUG.LOG(), .WARNING() Y .ERROR() se generen y vean en el LogCat() de Android, o su Dispositivo?")]
//    [SerializeField]
//    private bool _verDebugLogsWarningsErrors = false;

//    #endregion Utility y Miscelaneos



//    /// <summary>
//    /// Awake this instance.
//    /// </summary>
//    void Awake()
//    {
//        // Initialize pointer to this static instance, for that all GameObjects cann access It:
//        //
//        if (gm == null)
//        {
//            gm = gameObject.GetComponent<GameManager>();

//        }//End if

//        // Camara del Juego:
//        //
//        if (this._miCamaraRealDeLaApp == null) 
//        { 
//            // if ""this._miCamara"" is missing
//            ////////Debug.LogWarning("El Componente 'this._miCamara' esta faltando dentro de este GameObject. Agregando uno.");

//            // Agregando el componente dinamicamente: 'this._miCamara'.
//            //
//            this._miCamaraRealDeLaApp = Camera.main;

//        }//end if
//        //
//        // Hero of the Game:
//        //
//        if (_miPlayer == null) 
//        {
//            // El Balon representa al "Player".
//            //
//            _miPlayer = GameObject.FindWithTag("Balon");
//        }


//        #region Garbage Collection

//        // Initialize pointer to this static instance, for that all GameObjects can access It:
//        //
//        _miGarbageCollectionManager = new GarbageCollectionManager();

//        // No está activada la Limpieza cada N-segundos: activar para verificar cada n-segundos
//        //
//        /////EN DES-USO:    this._estaActivadoLimpiezaCadaNSegundosManual = true;
//        //
//        this._puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance = false;
//        //
//        // Basura en HEAP MEMORIA actual: Inicialización.
//        //
//        this._miMemoriaHeapGarbageActual = 0;
//        //
//        // Poner en cero el TIMER GENERAL DE GARBAGE para LIMPIAR.
//        //
//        this._miTiempoParaInvocarGCCollect = 0.0f;



//        //// Inicializa un HEAP GRANDE de basura:
//        ////
//        //_miGarbageCollectionManager.InicializarHeapAllocGrande();


//        #endregion Garbage Collection


//        #region Configuracion de App

//        // Configurar la App, para óptimo funcionamiento:
//        //
//        this.ConfigureAppInitialParameters();

//        #endregion Configuracion de App


//        // Obtener Componentes necesarios muy usados:
//        //
//        // MIC Input para el Balon:
//        //
//        this._miMicrophoneInputDelBalon = this._miPlayer.GetComponent<MicrophoneInput>();


//        // INICIALIZAR Variables de Jugadores:
//        //
//        this._miJugadorActualQueChuta = this._miJugadorUNO;
//        //
//        this._miJugadorCPU = _JUGADORES.CPU1;
//        //
//        this._miJugadorActualQuePortea = this._miJugadorCPU;
//        //
//        // Inicializar SCRIPTS:
//        //
//        // 1- SCRIPT de Portero:
//        // 1.1- CPU - I.A.:
//        //
//        this._miScriptConductaPorteroCPU = this._miPorteroCPU.GetComponent<ConductaIAPortero> ();
//        //
//        if (this._miScriptConductaPorteroCPU == null) 
//        { 
//            // if ""this._miScriptConductaPortero"" is missing
//            ////////Debug.LogWarning("El Componente '_miScriptConductaPortero' esta faltando dentro de este GameObject. Agregando uno.");

//            // Agregando el componente dinamicamente: '_miScriptConductaPortero'.
//            //
//            this._miScriptConductaPorteroCPU = gameObject.AddComponent<ConductaIAPortero>();

//        }//end if
//        //
//        // Inicialización del punto - GameObject: Cabeza:
//        //
//        this._miPorteroCPU_Cabeza_Transform = this._miPorteroCPU.transform.GetChild(0);
//        //
//        // Validacion: Usar el mismo GameObject en caso de que NO HAYA CABEZA:
//        //
//        if ( this._miPorteroCPU_Cabeza_Transform == null )
//        {

//            this._miPorteroCPU_Cabeza_Transform = this._miPorteroCPU.transform;

//        }//End if ( this._miPorteroCPU_Cabeza == null )
//        //
//        //
//        //
//        // 1.2- P1 - Humano:
//        //
//        this._miScriptControlPortero2D = this._miPorteroHumano.GetComponent<ControlPortero2D> ();
//        //
////        if (this._miScriptControlPortero2D == null) 
////        { 
////            // if ""this._miScriptConductaPortero"" is missing
////            ////////Debug.LogWarning("El Componente '_miScriptControlPortero2D' esta faltando dentro de este GameObject. Agregando uno.");
////
////            // Agregando el componente dinamicamente: '_miScriptConductaPortero'.
////            //
////            this._miScriptControlPortero2D = gameObject.AddComponent<ControlPortero2D>();
////
////        }//end if
//        //
//        //
//        // Inicialización del punto - GameObject: Cabeza:
//        //
//        this._miPorteroHumano_Cabeza_Transform = this._miPorteroHumano.transform.GetChild(0);
//        //
//        // Validacion: Usar el mismo GameObject en caso de que NO HAYA CABEZA:
//        //
//        if ( this._miPorteroHumano_Cabeza_Transform == null )
//        {

//            this._miPorteroHumano_Cabeza_Transform = this._miPorteroHumano.transform;

//        }//End if ( this._miPorteroCPU_Cabeza == null )

//        // 2- SCRIPT de 'Script de Conducta de IA de Chutador Del Penalty':
//        //
//        this._miScriptConductaIAChutadorDelPenalty = this._miPlayer.GetComponent<ConductaIAChutadorDelPenalty> ();


//        // 3- SCRIPT de 'Balon semi-transparente para APUNTAR':
//        //
//        this._miScriptConductaBalonIndicadorParaApuntar = this._miBalonIndicadorParaApuntar.GetComponent<ConductaMovimientoBasicoIzqDer> ();
//        //
//        if (this._miScriptConductaBalonIndicadorParaApuntar == null) 
//        { 
//            // if ""this._miScriptConductaPortero"" is missing
//            ////////Debug.LogWarning("El Componente '_miScriptConductaBalonIndicadorParaApuntar' esta faltando dentro de este GameObject. Agregando uno.");

//            // Agregando el componente dinamicamente: '_miScriptConductaPortero'.
//            //
//            this._miScriptConductaBalonIndicadorParaApuntar = gameObject.AddComponent<ConductaMovimientoBasicoIzqDer>();

//        }//end if           
//        //
//        // 3- SCRIPT de 'LineaDeGol', donde está el: 'Balon semi-transparente para APUNTAR':
//        //
//        this._miScriptLineaDeGol = this._miLineaDeGolMeta.GetComponent<LineaDeGol> ();
//        //
//        if (this._miScriptLineaDeGol == null) 
//        { 
//            // if ""this._miScriptLineaDeGol"" is missing
//            ////////Debug.LogWarning("El Componente '_miScriptLineaDeGol' esta faltando dentro de este GameObject. Agregando uno.");

//            // Agregando el componente dinamicamente: '_miScriptLineaDeGol'.
//            //
//            this._miScriptLineaDeGol = gameObject.AddComponent<LineaDeGol>();

//        }//end if


//        #region Ini de GUI

//        // GUI:
//        // Activar ""Botones simples de CANVAS UI V-2.0"":
//        // OPTIMIZAR:::::::::
//        // GameOver GameObject:
//        //
//        this._miGameOverButtonsGUICanvas.SetActive( false );


//        #region Menu Pausa / Lets Play

//        // Esconder por defecto el CANVAS del GameObject DE GUI de: Menú Pausa:
//        //
//        this.ActivarDesactivarCanvasGUIMenuPausaLetsPlayComponenteCanvas( false );     //this._miMenuPauseGUIComponenteCanvasEnGameObjectCanvas

//        #endregion Menu Pausa / Lets Play


//        #region GUI 'ROUND X' - UI TEXT

//        if ( this._miRoundTandaGUICanvas != null )
//        {
//            // Obtener el COMPONENTE CANVAS:
//            //
//            if (this._miRoundTandaGUIComponenteCanvasEnGameObjectCanvas == null) 
//            { 
//                // if ""this._miRoundTandaGUIComponenteCanvasEnGameObjectCanvas"" is missing
//                ////////Debug.LogWarning("El Componente '_miRoundTandaGUIComponenteCanvasEnGameObjectCanvas' esta faltando dentro de este GameObject. Agregando uno.");
            
//                // Obtener el COMPONENTE CANVAS:
//                //
//                this._miRoundTandaGUIComponenteCanvasEnGameObjectCanvas = this._miRoundTandaGUICanvas.GetComponent<Canvas>();

//            }//end if
//        }//end if


//        #endregion GUI 'ROUND X' - UI TEXT

//        #region GUI Barra de Goles - UI TEXT

//        // Ini de  GUI
//        //
//        if ( this._miGUIContenedoraDeScoreGolesAnotadosTextos != null )
//        {
//            // Obtener el COMPONENTE CANVAS:
//            //
//            if (this._miScoreGolesAnotadosTextosComponenteCanvasEnGameObjectCanvas == null) 
//            { 
//                // if ""this._miScoreGolesAnotadosTextosComponenteCanvasEnGameObjectCanvas"" is missing
//                ////////Debug.LogWarning("El Componente '_miScoreGolesAnotadosTextosComponenteCanvasEnGameObjectCanvas' esta faltando dentro de este GameObject. Agregando uno.");
            
//                // Obtener el COMPONENTE CANVAS:
//                //
//                this._miScoreGolesAnotadosTextosComponenteCanvasEnGameObjectCanvas = this._miGUIContenedoraDeScoreGolesAnotadosTextos.GetComponent<Canvas> ();

//            }//end if
//        }//end if


//        // Inicializar la LONGITUD de los arrays[] (Optimización)
//        //
//        // P1
//        //
//        this._p1GolesImagenesUI_Longitud = this._p1GolesImagenesUI.Length;
//        //
//        // P2
//        //
//        this._p2GolesImagenesUI_Longitud = this._p2GolesImagenesUI.Length;


//        #endregion GUI Barra de Goles - UI TEXT

////        #region GUI Barra de Goles
////        ///// LÍNEA DE PRUEBA, CAMBIO DE COLOR: this._p1GolesImagenesUI[0].color = Color.; //Color.black;
////        #endregion GUI Barra de Goles       


//        // GUI:
//        // Slider de Sensibilidad de Volumen del MICRÓFONO:
//        //
//        if (this._miSliderReconocimientoDeSonidos == null) 
//        {
            
//            // if ""this._miSliderReconocimientoDeSonidos"" is missing
//            ////////Debug.LogWarning ("El Componente '_miSliderReconocimientoDeSonidos' esta faltando dentro de este GameObject. Agregando uno.");

//            // Agregando el componente dinamicamente: '_miSliderReconocimientoDeSonidos'.
//            //
//            this._miSliderReconocimientoDeSonidos = gameObject.AddComponent<Slider> ();
//            //
//            // Seteo de Valores:
//            //
//            this._miSliderReconocimientoDeSonidos.wholeNumbers = true;
//            //
//            this._miSliderReconocimientoDeSonidos.minValue = 0;
//            this._miSliderReconocimientoDeSonidos.maxValue = this._miMicrophoneInputDelBalon.sensitivity * 2;
//            //this._miSliderReconocimientoDeSonidos.value = this._miMicrophoneInputDelBalon.sensitivity;
//            //
//            // Dimensiones
//            //
//            //this._miSliderReconocimientoDeSonidos.transform = gameObject.transform;

//        }//End if (this._miSliderReconocimientoDeSonidos == null)


//        // Setea el valor "por default" de la Sensibilidad del "Reconocedor de Sonidos".
//        //
//        // NO USADO ACA: PORQUE DEBE SER REALIZADO DIRECTAMENTE DESDE EL SCRIPT DEL MICROFONO, (cComponente que esta...) DENTRO DEL OBJETO BALON:
//        // this._miMicrophoneInputDelBalon.sensitivity = false;

      
//        // Si Ya existe un SLIDER: Inicializar valores de este Script relacionados:
//        //
//        // Valor INICIAL de SENSIBILIDAD del MICRÓFONO: VALOR INTERMEDIO TAMBIEN
//        //
//        this._miVolumenDeSensibilidadDefaultMicrofono = ((this._miSliderReconocimientoDeSonidos.maxValue - this._miSliderReconocimientoDeSonidos.minValue) / 2);
//        //
//        // Setear valor inicial del MICROFONO en la clase MICRÓFONO:
//        //
//        this._miMicrophoneInputDelBalon.sensitivity = this._miVolumenDeSensibilidadDefaultMicrofono;
//        //
//        // Conectar el valor del SLIDER contra el Microfono:
//        // Setear VALOR INICIAL del SLIDER (al valor inicial del MICRÓFONO de más arriba: ''this._miMicrophoneInputDelBalon.sensitivity''):
//        //
//        this.UpdatearGUISensibilidadReconocedorDeSonidos(this._miMicrophoneInputDelBalon.sensitivity);
//        //
//        // Adds a listener to the main slider and invokes a method when the value changes.
//        //
//        this._miSliderReconocimientoDeSonidos.onValueChanged.AddListener(delegate { UpdatearValorMicrofonoSensibilidadReconocedorDeSonidos(); });
//        //
//        // Hacer VISIBLE el elemento de GUI:
//        //
//        this._miSliderReconocimientoDeSonidos.enabled = true;

//        // Inicializar los COMPONENTES CANVAS del UI SLIDER DE RECONOCIMEINTO DE SONIDOS:
//        //
//        if ( ( this._misCanvasComponentUIDelSliderReconocimientoDeSonidos == null ) || ( this._misCanvasComponentUIDelSliderReconocimientoDeSonidos.Length <= 0 ) || ( this._misCanvasComponentUIDelSliderReconocimientoDeSonidos[0] == null ) )
//        {
//            // Como no se inicializó desde el INSPECTOR, debe hacerse buscando su TAG: 'CanvasComponentUiSliderReconocimientoDeSonidos':
//            //
//            GameObject[] misCanvasComponentUIDelSliderTemp = GameObject.FindGameObjectsWithTag("CanvasComponentUiSliderReconocimientoDeSonidos");

//            if ( misCanvasComponentUIDelSliderTemp != null )
//            {
//                // BUSCAR + Agregar (CANVAS COMPONENT que es un 'Component' que está exactamente en el GameObject con el TAG buscado anteriormente)
//                //
//                int longitudArray = misCanvasComponentUIDelSliderTemp.Length;
//                //
//                // Inicializar el Array():
//                //
//                this._misCanvasComponentUIDelSliderReconocimientoDeSonidos = new /*Game*/  Object[ longitudArray ];
//                //
//                for (int i = 0; i < longitudArray; i++)
//                {
//                    // Extraer el 'Componente Canvas' y asignárselo a una casilla del Array:
//                    //
//                    this._misCanvasComponentUIDelSliderReconocimientoDeSonidos[ i ] = misCanvasComponentUIDelSliderTemp[ i ] /*.GetComponent<Canvas>() as GameObject*/;

//                }//End for

//                // Chequeo de ÚLTIMA HORA: Es != null ??
//                //
//                if ( this._misCanvasComponentUIDelSliderReconocimientoDeSonidos[0] == null )
//                {
//                    // Forma de Advertencia:
//                    //
//                    Debug.LogWarning("El Componente '_misCanvasComponentUIDelSliderReconocimientoDeSonidos' esta faltando (porque no fue agregado dentro del INSPECTOR en clase 'GameManager.cs') dentro de este GameObject.\n...Y NO PODEMOS ENCONTRARLO CON EL TAG = 'CanvasComponentUiSliderReconocimientoDeSonidos'.\n....Se deberá detener la ejecución");

//                }//End if

//            }//End if
//            else
//            {
//                // If ""this._miScoreGolesAnotadosTextosComponenteCanvasEnGameObjectCanvas"" is missing
//                //
//                //Debug.LogError("El Componente '_misCanvasComponentUIDelSliderReconocimientoDeSonidos' esta faltando (porque no fue agregado dentro del INSPECTOR en clase 'GameManager.cs') dentro de este GameObject.\n...Y NO PODEMOS ENCONTRARLO CON EL TAG = 'CanvasComponentUiSliderReconocimientoDeSonidos'.\n....Se deberá detener la ejecución");
//                //
//                // Forma de Advertencia:
//                //
//                Debug.LogWarning("El Componente '_misCanvasComponentUIDelSliderReconocimientoDeSonidos' esta faltando (porque no fue agregado dentro del INSPECTOR en clase 'GameManager.cs') dentro de este GameObject.\n...Y NO PODEMOS ENCONTRARLO CON EL TAG = 'CanvasComponentUiSliderReconocimientoDeSonidos'.\n....Se deberá detener la ejecución");

//            }//End else

//        }//End if ( ( this._misCanvasComponentUIDelSliderReconocimientoDeSonidos == null ) || ( this._misCanvasComponentUIDelSliderReconocimientoDeSonidos[0] == null ) )


//        // Inicializar la LONGITUD DE ARRAY[] (Optimización)
//        //
//        this._misCanvasComponentUIDelSliderReconocimientoDeSonidos_Longitud = this._misCanvasComponentUIDelSliderReconocimientoDeSonidos.Length;


////        #region VOLUMEN MAESTRO de la App
////
////        this.ActualizarMasterVolume();
////
////        #endregion

////      // setup score (puntos-Oro del juego) display
////      Collect (0);
////
////      // setup goles UI
////      Collect (0);

////      // make other UI inactive
////      gameOverCanvas.SetActive (false);
////      if (canBeatLevel)
////          beatLevelCanvas.SetActive (false);

//        #endregion Ini de GUI


//        #region Camara y Animaciones


//        // Obtener los SCRIPTS PARA MOVER LA CAMARA:
//        // 1- Posiciones de Enfoque de Cámara para PODER JUGAR: A- COMO CHUTADOR... B- COMO PORTERO:
//        //
//        ArrayList _miListaDeScriptsDeCamara = new ArrayList();
//        _miListaDeScriptsDeCamara.AddRange( this._miCamaraAparente.GetComponents<CamaraEnfocarUnPuntoYMoverseADestino>() );

//        // Ahora hay 2 Objetos Scripts para mover la Cámara:
//        // 0-  Como Chutador
//        // 1-  Como Portero
//        //
//        int tamanoLista = _miListaDeScriptsDeCamara.Count;
//        //
//        // 0-  Como Chutador
//        //
//        if (tamanoLista > 0)
//        { 
//            // Agregando el componente dinamicamente: ''.
//            //
//            this._miScriptCamaraEnfocarUnPuntoYMoverseADestinoChutar = _miListaDeScriptsDeCamara[0] as CamaraEnfocarUnPuntoYMoverseADestino;

//        }//end if
//        //
//        // 1-  Como Portero
//        //
//        if (tamanoLista > 1)
//        { 
//            // Agregando el componente dinamicamente: ''.
//            //
//            this._miScriptCamaraEnfocarUnPuntoYMoverseADestinoPortear = _miListaDeScriptsDeCamara[1] as CamaraEnfocarUnPuntoYMoverseADestino;

//        }//end if

////        ///////////////////
////        // 2-   Animación de PELIGRO: Cuando puede Terminar allí el Partido.
////        //
////        this._miScriptCamaraParaAnimacionDePeligroEnfocarMuchosPuntosYMoverseAMuchosDestinos = this._miCamara.GetComponent<CamaraEnfocarMuchosPuntosYMoverseAMuchosDestinos>();
////        //
////        this._miScriptCamaraParaAnimacionDePeligroEnfocarMuchosPuntosYMoverseAMuchosDestinos._movermeAhora = false;
////        this._miScriptCamaraParaAnimacionDePeligroEnfocarMuchosPuntosYMoverseAMuchosDestinos.enabled = false;
////
////        /////////////////
//        // 2-   Animación de PELIGRO: Cuando puede Terminar allí el Partido. Y +
//        // 3-   Animación de GOOOOOL    (Enfoques de Cámara) +
//        // 4-       y NO-GOL            (Enfoque de Cámara).
//        //
//        ArrayList _miListaDeScriptsDeCamaraAnimaciones = new ArrayList();
//        _miListaDeScriptsDeCamaraAnimaciones.AddRange( this._miCamaraAparente.GetComponents<CamaraEnfocarMuchosPuntosYMoverseAMuchosDestinos>() );

//        // Ahora hay 2 Objetos Scripts para mover la Cámara:
//        // 0-   Animación de PELIGRO: Cuando puede Terminar allí el Partido.
//        // 1-   Al meter GOOOL (Chutador del Penalty) ó     Al lograr una SALVADA (Portero)
//        //
//        int tamanoLista2 = _miListaDeScriptsDeCamaraAnimaciones.Count;
//        //
//        int scriptDeCamaraIesimo = 1;
//        //
//        // 0-   Animación de PELIGRO: Cuando puede Terminar allí el Partido.
//        //
//        if (tamanoLista2 >= scriptDeCamaraIesimo)
//        { 
//            // Agregando el componente dinamicamente: ''.
//            //
//            this._miScriptCamaraParaAnimacionDePeligroEnfocarMuchosPuntosYMoverseAMuchosDestinos = _miListaDeScriptsDeCamaraAnimaciones[ scriptDeCamaraIesimo - 1 ] as CamaraEnfocarMuchosPuntosYMoverseAMuchosDestinos;
//            //
//            this._miScriptCamaraParaAnimacionDePeligroEnfocarMuchosPuntosYMoverseAMuchosDestinos._movermeAhora = false;
//            this._miScriptCamaraParaAnimacionDePeligroEnfocarMuchosPuntosYMoverseAMuchosDestinos.enabled = false;

//        }//end if
//        //
//        // Incrementar el i-ésimo Script de cámara que se cuenta...
//        //
//        scriptDeCamaraIesimo++;
//        //
//        // 1-   Al meter GOOOL (Chutador del Penalty) ó     Al lograr una SALVADA (Portero)
//        //
//        if (tamanoLista2 >= scriptDeCamaraIesimo)
//        {
//            // Agregando el componente dinamicamente: ''.
//            //
//            this._miScriptCamaraParaAnimacionDeGolOSalvadaEnfocarMuchosPuntosYMoverseAMuchosDestinos = _miListaDeScriptsDeCamaraAnimaciones[ scriptDeCamaraIesimo - 1 ] as CamaraEnfocarMuchosPuntosYMoverseAMuchosDestinos;
//            //
//            this._miScriptCamaraParaAnimacionDeGolOSalvadaEnfocarMuchosPuntosYMoverseAMuchosDestinos._movermeAhora = false;
//            this._miScriptCamaraParaAnimacionDeGolOSalvadaEnfocarMuchosPuntosYMoverseAMuchosDestinos.enabled = false;

//        }//end if
//        //
//        // Incrementar el i-ésimo Script de cámara que se cuenta...
//        //
//        scriptDeCamaraIesimo++;
//        //
//        // 2-   Al ""GANAR"" o ""PERDER"" el JUEGO al FINAL.
//        //
//        if (tamanoLista2 >= scriptDeCamaraIesimo)
//        { 
//            // Agregando el componente dinamicamente: ''.
//            //
//            this._miScriptCamaraParaAnimacionAlGanarOPerderEnfocarMuchosPuntosYMoverseAMuchosDestinos = _miListaDeScriptsDeCamaraAnimaciones[scriptDeCamaraIesimo - 1] as CamaraEnfocarMuchosPuntosYMoverseAMuchosDestinos;
//            //
//            this._miScriptCamaraParaAnimacionAlGanarOPerderEnfocarMuchosPuntosYMoverseAMuchosDestinos._movermeAhora = false;
//            this._miScriptCamaraParaAnimacionAlGanarOPerderEnfocarMuchosPuntosYMoverseAMuchosDestinos.enabled = false;

//        }//end if

//        // Script de Rotacion (Panorámica) de la Cámara: Al FINAL DEL JUEGO: WIN o LOSE:
//        //
//        // 3- SCRIPT de 'Rotate':
//        //
//        this._miScriptCamaraParaAnimacionAlGanarOPerderRotacionPanoramicaAlrededorDelMundo = this._miCamaraAparente.GetComponent<Rotate>();
//        //
//        if (this._miScriptCamaraParaAnimacionAlGanarOPerderRotacionPanoramicaAlrededorDelMundo == null) 
//        { 
//            // if ""this._miScriptCamaraParaAnimacionAlGanarOPerderRotacionPanoramicaAlrededorDelMundo"" is missing
//            ////////Debug.LogWarning("El Componente '_miScriptCamaraParaAnimacionAlGanarOPerderRotacionPanoramicaAlrededorDelMundo' esta faltando dentro de este GameObject. Agregando uno.");

//            // Agregando el componente dinamicamente: '_miScriptCamaraParaAnimacionAlGanarOPerderRotacionPanoramicaAlrededorDelMundo'.
//            //
//            this._miScriptCamaraParaAnimacionAlGanarOPerderRotacionPanoramicaAlrededorDelMundo = this.gameObject.AddComponent<Rotate>();

//            // Seteo de sus propiedades por default:
//            //
//            this._miScriptCamaraParaAnimacionAlGanarOPerderRotacionPanoramicaAlrededorDelMundo.speed = -10.0f;
//            this._miScriptCamaraParaAnimacionAlGanarOPerderRotacionPanoramicaAlrededorDelMundo.way = Rotate.whichWayToRotate.AroundY;
//            //
//            // Apagar por ahora:
//            //
//            this._miScriptCamaraParaAnimacionAlGanarOPerderRotacionPanoramicaAlrededorDelMundo.enabled = false;

//        }//end if

//        #region Animacion de Personajes

//        // 1-   Animator (Controlador de Animaciones) de PORTERO CPU:
//        //
//        this._miAnimatorPorteroCPU = this._miPorteroCPU.GetComponent<Animator>();
//        //
//        if (this._miAnimatorPorteroCPU == null)     // if Animator is missing
//        {

//            Debug.LogError ("Error importante (asociar '_miAnimatorPorteroCPU' en 'GameManager.cs'): Animator component missing from this gameobject");
//        }
//        //
//        // 2-   Animator (Controlador de Animaciones) de PORTERO PLAYER P1:
//        //
//        this._miAnimatorPorteroPlayerP1 = this._miPorteroHumano.GetComponent<Animator>();
//        //
//        if (this._miAnimatorPorteroPlayerP1 == null)     // if Animator is missing
//        {

//            Debug.LogError ("Error importante (asociar '_miAnimatorPorteroPlayerP1' en 'GameManager.cs'): Animator component missing from this gameobject");
//        }

//        // Llenar array para Animaciones elegidas aleatoriamente:
//        // 1.1- PORTERO NO-GOL:
//        //
//        this._miListaHashAnimacionesPorteroDeNoGol = new int[] 
//        {
//            _PORTERO_CELEBRA_RODANDO_TRIGGER_PARAMETER_ANIMATION_STATE_HASH, 
//            _PORTERO_CELEBRA_CRECIENDO_TRIGGER_PARAMETER_ANIMATION_STATE_HASH
//        };

//        // 1.2- PORTERO GOL: No celebra.
//        //
//        this._miListaHashAnimacionesPorteroDeGoool = new int[] 
//        {
//            _PORTERO_NO_CELEBRA_CAEPARAATRAS_TRIGGER_PARAMETER_ANIMATION_STATE_HASH,
//            _PORTERO_NO_CELEBRA_DECRECIENDOHASTADESAPARECER_TRIGGER_PARAMETER_ANIMATION_STATE_HASH, 
//            _PORTERO_NO_CELEBRA_ROTAHORIZONTAL_TRIGGER_PARAMETER_ANIMATION_STATE_HASH
//        };


//        // Inicializacion de Longitud del Array[]
//        //
//        this._miListaHashAnimacionesPorteroDeGoool_Longitud = this._miListaHashAnimacionesPorteroDeGoool.Length;
//        //
//        // Inicializacion de Longitud del Array[]
//        //
//        this._miListaHashAnimacionesPorteroDeNoGol_Longitud = this._miListaHashAnimacionesPorteroDeNoGol.Length;

//        #endregion Animacion de Personajes

//        #endregion Camara y Animaciones


//        #region Animaciones de Letras en pantalla

//        this._miScriptAnimacionesLetrasEnPantalla = this.gameObject.GetComponent<AnimacionesLetrasEnPantalla>();
//        //
//        if (this._miScriptAnimacionesLetrasEnPantalla == null) 
//        { 
//            // if ""this._miScriptAnimacionesLetrasEnPantalla"" is missing
//            ////////Debug.LogWarning("El Componente '_miScriptAnimacionesLetrasEnPantalla' esta faltando dentro de este GameObject. Agregando uno.");

//            // Agregando el componente dinamicamente: '_miScriptAnimacionesLetrasEnPantalla'.
//            //
//            this._miScriptAnimacionesLetrasEnPantalla = this.gameObject.AddComponent<AnimacionesLetrasEnPantalla>();

//        }//end if


//        #endregion Animaciones de Letras en pantalla


//        #region Sonidos y Musica

//        // Obtener 'AudiosSources' en el hijo de la Camara (ver 'MainCamera' en la Jerarquía del UNITY3D):
//        //
//        AudioSource[] miListaDeAudiosSources = this._miCamaraAparente.GetComponentsInChildren<AudioSource>();

//        // Asignar c/'canal de audio' a su respectiva variable:
//        // 1- Silbatazos:
//        //
//        this._miAudioSourceSilbatazos = miListaDeAudiosSources[0];
//        //
//        // 2- Bulla de Goool (o No-Gol-Abucheo) del PÚBLICO:
//        //
//        this._miAudioSourceBullaPublicoEmocionGol = miListaDeAudiosSources[1];
//        //
//        // 3- Comentarios del 'Comentarista':
//        //
//        this._miAudioSourceComentarista = miListaDeAudiosSources[2];
//        //
//        // Bandera de ""Falta reproducir sonido de Comentarista"": Inicializar
//        //
//        this._faltaReproducirSonidoDeGol = true;
//        this._faltaReproducirSonidoAlFinalDeGanarOPerder = true;
//        this._faltaReproducirSonidoComentarioCuandoJuegoEstaEnPeligroDeTerminar = true;
//        this._faltaReproducirSonidoComentariosAlEntrarEnFaseDeSuddenDeath = true;
//        //
////        // 4- Fuegos Artificiales, CANAL 1 de sonidos (porque pueden haber varios canales):
////        //
////        this._miAudioSourceFuegosArtificiales_1 = miListaDeAudiosSources[3];
////
//        // 4- Animaciones (para el PORTERO), CANAL 1 de sonidos (porque pueden haber varios canales):
//        //
//        this._miAudioSourceAnimacionesDelPortero = miListaDeAudiosSources[3];


//        // n- AudioSource FINAL:  (esta encendido desde elk EDITOR, el GAME OBJECT: ''SonidosDelJuego'' que es un HIJO/CHILD del Objecto: ''Main Camera'').
//        //
//        // NOTA IMPORTANTE A MI MISMO: Considerar que el ultimo "AudioSource" es uno agregado directamente al GameObject, al final.
//        // ...Éste servirá para REPRODUCIR LA MÚSICA DE FONDO = BULLA DE PÚBLICO DE FONDO.
//        // * Tiene como opción LOOP, y PLAY_ON_AWAKE...
//        // * Se reproduce por eso: Solo, SIN CÓDIGO de este SCRIPT, sino desde el UNITY EDITOR, ... por como está configurado el GAME OBJECT.
//        // * Si llega a fallar o dejarse de escuchar la BULLA DE PÚBLICO DE FONDO, es debido a que se hizo un STOP o un DISABLE/DESTROY en este audioSource DEL array_list, EN ESA POSICIÓN: LA última.
//        //
//        // n- Bulla Constante del Publico en el ESTADIO, como se ha explicado arriba:
//        //
//        this._miAudioSourceBullaGritosHumanosNormalConstante = miListaDeAudiosSources[4];

//        #endregion Sonidos y Musica


//        #region Efectos Visuales

//        // Obtener SCRIPT de efecto visual blanco-negro:
//        //
//        this._miScriptEfectoGrayscale = this._miCamaraRealDeLaApp.GetComponentInChildren<Grayscale>();
//        //
//        if (this._miScriptEfectoGrayscale == null) 
//        { 
//            // if ""this._miScriptEfectoGrayscale"" is missing
//            ////////Debug.LogWarning("El Componente '_miScriptEfectoGrayscale' esta faltando dentro de este GameObject. Agregando uno.");

//            // Agregando el componente dinamicamente: '_miScriptEfectoGrayscale'.
//            //
//            this._miScriptEfectoGrayscale = this._miCamaraRealDeLaApp.gameObject.AddComponent<Grayscale>();
//            //
//            // Obtener SCRIPT de efecto visual blanco-negro:
//            //
//            this._miScriptEfectoGrayscale = this._miCamaraRealDeLaApp.GetComponentInChildren<Grayscale>();

//        }//end if
//        //
//        // Inicializacion: Restablecer el color-Effect del Escenario (Blanco-Negro-> a -> Normal):
//        //
//        this._miScriptEfectoGrayscale.enabled = false;

//        #endregion Efectos Visuales


//        #region Sombras Dinamicas

//        // Versión 1: Trabajar con SOMBRAS PERSONALIZADAS ""SIEMPRE"": BALON, PORTERO P1, PORTERO CPU.
//        //
//        // Validar, si ha sido AGREGADO AL ATRIBUTO PUBLICO: por el ser humano: Iniciar el resto de INICIALIZACION AUTOMATICA.
//        // Manager:
//        //
//        if ( this._miScriptShadowsDynamicManager == null )
//        {

//            // Agregando el componente dinamicamente: '_miScriptShadowsDynamicManager'.
//            //
//            this._miScriptShadowsDynamicManager = this.gameObject.GetComponent<ShadowsDynamicManager>();

//            // Verificar si todavia estamos nulos. Si fuera así: Agregar en gameobject y en este Script tambien:
//            //
//            if ( this._miScriptShadowsDynamicManager == null )
//            {
//                // Acá (en GameManager.cs):
//                //
//                // Agregando el componente dinamicamente: '_miScriptConteoDeTiempoEsperaCuandoElBalonEsDetenido'.
//                //
//                this._miScriptShadowsDynamicManager = GameObject.FindWithTag("DynamicShadowsManager").GetComponent<ShadowsDynamicManager>();  //AddComponent<ConteoDeTiempo>();

//            }//End if

//        }//End if ( this._miScriptShadowsDynamicManager == null )
//        //
//        // GameObject de HEROES: 1 = Balon , 2 = Portero P1, 3 = Portero CPU.
//        //
//        if ( this._miScriptShadowsDynamicManager != null )
//        {

//            // GameObject de Sombras (agregado inicial): 1 = Balon , 2 = Portero P1, 3 = Portero CPU.
//            // 1- Balon
//            //
//            if ( this._miSombraDelBalon == null )
//            {
//                // Agregar en este Script
//                //
//                this._miSombraDelBalon = GameObject.FindWithTag("SombraDelBalon1");


//                // Agregar en el Propio GameObject que tiene al ""Sombras Manager"":
//                //
//                //(... Se hará más abajo, adelante. Se usará un apuntador a este OBJETO de arriba ).

//            }//End if ( this._miSombraDelBalon == null )


//            // 2- Portero P1
//            //
//            if ( this._miSombraDelPorteroP1 == null )
//            {
//                // Agregar en este Script
//                //
//                this._miSombraDelPorteroP1 = GameObject.FindWithTag("SombraDelPorteroP1_1");


//                // Agregar en el Propio GameObject que tiene al ""Sombras Manager"":
//                //
//                //(... Se hará más abajo, adelante. Se usará un apuntador a este OBJETO de arriba ).

//            }//End if ( this._miSombraDelPorteroP1 == null )


//            // 3- Portero CPU
//            //
//            if ( this._miSombraDelPorteroCPU == null )
//            {
//                // Agregar en este Script
//                //
//                this._miSombraDelPorteroCPU = GameObject.FindWithTag("SombraDelPorteroCPU_1");


//                // Agregar en el Propio GameObject que tiene al ""Sombras Manager"":
//                //
//                //(... Se hará más abajo, adelante. Se usará un apuntador a este OBJETO de arriba ).

//            }//End if ( this._miSombraDelPorteroCPU == null )


//            //////////
//            // Inicializacion completa de los objetos asociados a este Script y al Script SHADOW MANAGER:
//            //////////

//            // Heroes con Sombras, HARDCODED:
//            //
//            this._miScriptShadowsDynamicManager._miListaDeHeroes = new GameObject[ _MI_NUMERO_DE_HEROES_CON_SOMBRA_DINAMICA ];
//            //
//            // Sombras de esos Héroes:
//            //
//            this._miScriptShadowsDynamicManager._miListaDeSombras = new GameObject[ _MI_NUMERO_DE_HEROES_CON_SOMBRA_DINAMICA ];


//            // INICIALIZACION APROPIADA:::::::::::
//            // 1- Iniciar el Balon
//            // Casilla [0]
//            //
//            this._miScriptShadowsDynamicManager._miListaDeHeroes[ _MI_INDICE_SOMBRA_DIN_BALON ] = this._miPlayer;
//            //
//            // SOMBRA
//            //
//            this._miScriptShadowsDynamicManager._miListaDeSombras[ _MI_INDICE_SOMBRA_DIN_BALON ] = this._miSombraDelBalon;


//            // 2- Iniciar Portero P1
//            // Casilla [1]
//            //
//            this._miScriptShadowsDynamicManager._miListaDeHeroes[ _MI_INDICE_SOMBRA_DIN_PORTERO_P1 ] = this._miPorteroHumano;
//            //
//            // SOMBRA
//            //
//            this._miScriptShadowsDynamicManager._miListaDeSombras[ _MI_INDICE_SOMBRA_DIN_PORTERO_P1 ] = this._miSombraDelPorteroP1;


//            // 3- Iniciar Portero CPU
//            // Casilla [2]
//            //
//            this._miScriptShadowsDynamicManager._miListaDeHeroes[ _MI_INDICE_SOMBRA_DIN_PORTERO_CPU ] = this._miPorteroCPU;
//            //
//            // SOMBRA
//            //
//            this._miScriptShadowsDynamicManager._miListaDeSombras[ _MI_INDICE_SOMBRA_DIN_PORTERO_CPU ] = this._miSombraDelPorteroCPU;


//            // Activar TODOS los GameObjects de Sombras (el 'Sistema' completo):
//            //
//            this._miScriptShadowsDynamicManager.ActivarDesactivarSistemaDeSombrasDinamicas( true );


//            // Inicializar e iniciar el Script de MANAGER DE SOMBRAS DINAMICAS:
//            //
//            this._miScriptShadowsDynamicManager.Inicializar();

//        }//End if ( this._miScriptShadowsDynamicManager != null )
//        //
//        //
//        // Opción 2: Trabajar OPCIONALMENTE: Con o SIN Sombras.
//        //
////        if ( this._miScriptShadowsDynamicManager != null )
////        {
////
////            // Heroes con Sombras, HARDCODED:
////            //
////            this._miScriptShadowsDynamicManager._miListaDeHeroes = new GameObject[ _MI_NUMERO_DE_HEROES_CON_SOMBRA_DINAMICA ];
////            //
////            // Sombras de esos Héroes:
////            //
////            this._miScriptShadowsDynamicManager._miListaDeSombras = new GameObject[ _MI_NUMERO_DE_HEROES_CON_SOMBRA_DINAMICA ];
////
////
////            // INICIALIZACION APROPIADA:::::::::::
////            // 1- Iniciar el Balon
////            // Casilla [0]
////            //
////            this._miScriptShadowsDynamicManager._miListaDeHeroes[ _MI_INDICE_SOMBRA_DIN_BALON ] = this._miPlayer;
////            //
////            // SOMBRA
////            //
////            this._miScriptShadowsDynamicManager._miListaDeSombras[ _MI_INDICE_SOMBRA_DIN_BALON ] = this._miSombraDelBalon;
////
////
////            // 2- Iniciar Portero P1
////            // Casilla [1]
////            //
////            this._miScriptShadowsDynamicManager._miListaDeHeroes[ _MI_INDICE_SOMBRA_DIN_PORTERO_P1 ] = this._miPorteroHumano;
////            //
////            // SOMBRA
////            //
////            this._miScriptShadowsDynamicManager._miListaDeSombras[ _MI_INDICE_SOMBRA_DIN_PORTERO_P1 ] = this._miSombraDelPorteroP1;
////
////
////            // 3- Iniciar Portero CPU
////            // Casilla [2]
////            //
////            this._miScriptShadowsDynamicManager._miListaDeHeroes[ _MI_INDICE_SOMBRA_DIN_PORTERO_CPU ] = this._miPorteroCPU;
////            //
////            // SOMBRA
////            //
////            this._miScriptShadowsDynamicManager._miListaDeSombras[ _MI_INDICE_SOMBRA_DIN_PORTERO_CPU ] = this._miSombraDelPorteroCPU;
////
////
////            // Activar TODOS los GameObjects de Sombras (el 'Sistema' completo):
////            //
////            this._miScriptShadowsDynamicManager.ActivarDesactivarSistemaDeSombrasDinamicas( true );
////
////
////            // Inicializar e iniciar el Script de MANAGER DE SOMBRAS DINAMICAS:
////            //
////            this._miScriptShadowsDynamicManager.Inicializar();
////
////        }//end if (SCRIPT != null)

//        #endregion Sombras Dinamicas


//        #region Ecuacion Linea Recta SENSIBILIDAD (X) vs. MASTER VOLUME (Y)

//        // Solo de Referencia: PORQUE YA SE HZO ARRIBA AL INICIALIZAR EL SLIDER DE SENSITIVITY:
//        //
////        // Valor INICIAL de SENSIBILIDAD del MICRÓFONO: VALOR INTERMEDIO TAMBIEN
////        //
////        this._miVolumenDeSensibilidadDefaultMicrofono = ((this._miSliderReconocimientoDeSonidos.maxValue - this._miSliderReconocimientoDeSonidos.minValue) / 2);
////        //
////        // Setear valor inicial del MICROFONO en la clase MICRÓFONO:
////        //
////        this._miMicrophoneInputDelBalon.sensitivity = this._miVolumenDeSensibilidadDefaultMicrofono;

//        // INICIALIZACION DE VOLUMENES MÍNIMOS Y MÁXIMOS:
//        //
//        //this._volumenMinimoSilbatos = 0.05f;
//        //
//        //Caso desde el Inspector:
//        //
//        this._volumenMaximoBullaFondoPublico = this._miAudioSourceBullaGritosHumanosNormalConstante.volume;

//        // Ecuación de LÍNEA RECTA: y = VOLUMEN Sonidos;  x = SENSITIVITY DEL MICROFONO (y/o SLIDER).
//        // Caso 1: SILBATO del árbitro.
//        // m = Pendiente
//        //
//        this._miPendienteM_SensibilidadMicVsVolumenSilbatos = this.CalculaYDevuelvePendienteMdeLineaRecta( this._volumenMinimoSilbatos, this._volumenMaximoSilbatos, this._miSliderReconocimientoDeSonidos.maxValue, this._miVolumenDeSensibilidadDefaultMicrofono);
//        //
//        // b = Ordenada (y) en el Origen (x=0):
//        //
//        this._miOrdenadaEnOrigenB_SensibilidadMicVsVolumenSilbatos = this.CalculaYDevuelveOrdenadaEnOrigenBdeLineaRecta( this._miPendienteM_SensibilidadMicVsVolumenSilbatos, this._miSliderReconocimientoDeSonidos.maxValue );

//        // Ecuación de LÍNEA RECTA: y = VOLUMEN Sonidos;  x = SENSITIVITY DEL MICROFONO (y/o SLIDER).
//        // Caso 2: BULLA DE PÚBLICO de FONDO.
//        // m = Pendiente
//        //
//        this._miPendienteM_SensibilidadMicVsVolumenBullaPublicoFondo = this.CalculaYDevuelvePendienteMdeLineaRecta( this._volumenMinimoBullaFondoPublico, /* este valor es el sonido de BULLA Inicial, por DEFAULT = */ this._volumenMaximoBullaFondoPublico, this._miSliderReconocimientoDeSonidos.maxValue, this._miVolumenDeSensibilidadDefaultMicrofono);
//        //
//        // b = Ordenada (y) en el Origen (x=0):
//        //
//        this._miOrdenadaEnOrigenB_SensibilidadMicVsVolumenBullaPublicoFondo = this.CalculaYDevuelveOrdenadaEnOrigenBdeLineaRecta( this._miPendienteM_SensibilidadMicVsVolumenBullaPublicoFondo, this._miSliderReconocimientoDeSonidos.maxValue );


////        // Ecuación de LÍNEA RECTA: y = MASTER_VOLUME;  x = SENSITIVITY DEL MICROFONO (y/o SLIDER).
////        // M = Pendiente:
////        //
////        this._miPendienteM_SensibilidadMicVsVolumenSilbatos = ((0.0f - 1.0f) / (this._miSliderReconocimientoDeSonidos.maxValue - this._miVolumenDeSensibilidadDefaultMicrofono));
////        //
////        // Intercepto en el origen (y=? cuando x=0): b:
////        //
////        this._miInterceptoEnOrigenB_SensibilidadMicVsVolumenSilbatos = (-1) * ( this._miPendienteM_SensibilidadMicVsVolumenSilbatos * this._miSliderReconocimientoDeSonidos.maxValue );

//        #endregion Ecuacion Linea Recta SENSIBILIDAD (X) vs. MASTER VOLUME (Y)


//        #region Corrutinas - Optimizacion

//        // ================================

//        // 0- Longitudes de Arrays:

//        // Longitud del Array
//        //
//        this._miListaSonidosBalonPatada_Longitud = this._miListaSonidosBalonPatada.Length;

//        // Longitud del Array
//        //
//        this._miListaSonidosBalonColisionConPostePorteria_Longitud = this._miListaSonidosBalonColisionConPostePorteria.Length;

//        // Longitud del Array
//        //
//        this._miListaSonidosBalonColisionConManosDePortero_Longitud = this._miListaSonidosBalonColisionConManosDePortero.Length;

//        // Longitud del Array
//        //
//        this._miListaSonidosBullaDeGOOOL_Longitud = this._miListaSonidosBullaDeGOOOL.Length;

//        // Longitud del Array
//        //
//        this._miListaSonidosBullaDeFallarElGOOOLAbucheo_Longitud = this._miListaSonidosBullaDeFallarElGOOOLAbucheo.Length;

//        // Longitud del Array
//        //
//        this._miListaDeSonidosComentarioDeGol_Longitud = this._miListaDeSonidosComentarioDeGol.Length;

//        // Longitud del Array
//        //
//        this._miListaDeSonidosComentarioDeNoGol_Longitud = this._miListaDeSonidosComentarioDeNoGol.Length;

//        // Longitud del Array
//        //
//        this._miListaDeSonidosComentariosAlChutadorGol_Longitud = this._miListaDeSonidosComentariosAlChutadorGol.Length;

//        // Longitud del Array
//        //
//        this._miListaDeSonidosComentariosDestructivosChutadorOPortero_Longitud = this._miListaDeSonidosComentariosDestructivosChutadorOPortero.Length;

//        // Longitud del Array
//        //
//        this._miListaDeSonidosComentariosAlPorteroSalvadaExitosa_Longitud = this._miListaDeSonidosComentariosAlPorteroSalvadaExitosa.Length;

//        // Longitud del Array
//        //
//        this._miListaDeSonidosComentariosAlFinalAlGanar_Longitud = this._miListaDeSonidosComentariosAlFinalAlGanar.Length;

//        // Longitud del Array
//        //
//        this._miListaDeSonidosComentariosAlFinalAlPerder_Longitud = this._miListaDeSonidosComentariosAlFinalAlPerder.Length;

//        // Longitud del Array
//        //
//        this._miListaDeSonidosComentariosCuandoJuegoEstaEnPeligroDeTerminar_Longitud = this._miListaDeSonidosComentariosCuandoJuegoEstaEnPeligroDeTerminar.Length;

//        // Longitud del Array
//        //
//        this._miListaDeSonidosComentariosAlEntrarEnFaseDeSuddenDeath_Longitud = this._miListaDeSonidosComentariosAlEntrarEnFaseDeSuddenDeath.Length;


//        // ==================================

//        // 1- Corrutina, Optimización:
//        //

//        // 1-   Corrutina de:   _miListaDeSonidosComentarioDeGol        ============================================

////        // Longitud del Array:
////        //
////        this._miListaDeSonidosComentarioDeGol_Longitud = this._miListaDeSonidosComentarioDeGol.Length;

//        //this._miListaDelayPlaySonidoGolNoGol_WaitForSeconds = new WaitForSeconds( this._miAudioSourceComentarista.clip.length );

//        // Crear la Lista
//        //
//        this._miListaDelayPlaySonidoGol_WaitForSeconds = new WaitForSeconds[ this._miListaDeSonidosComentarioDeGol_Longitud ];

//        // Llenar la Lista:
//        // Recorrer la lista '_miListaDeSonidosComentarioDeGol' para crear tantos WaitForSeconds como haga falta.
//        //
//        for (int i = 0; i < this._miListaDeSonidosComentarioDeGol_Longitud; i++)
//        {

//            // Crear la Lista
//            //
//            this._miListaDelayPlaySonidoGol_WaitForSeconds[ i ] = new WaitForSeconds( this._miListaDeSonidosComentarioDeGol[i].length );

//        }//End for

//        // 2-   Corrutina de:   _miListaDeSonidosComentarioDeNoGol      ============================================

////        // Longitud del Array:
////        //
////        this._miListaDeSonidosComentarioDeNoGol_Longitud = this._miListaDeSonidosComentarioDeNoGol.Length;

//        //this._miListaDelayPlaySonidoGolNoGol_WaitForSeconds = new WaitForSeconds( this._miAudioSourceComentarista.clip.length );

//        // Crear la Lista
//        //
//        this._miListaDelayPlaySonidoNoGol_WaitForSeconds = new WaitForSeconds[ this._miListaDeSonidosComentarioDeNoGol_Longitud ];

//        // Llenar la Lista:
//        // Recorrer la lista '_miListaDeSonidosComentarioDeGol' para crear tantos WaitForSeconds como haga falta.
//        //
//        for (int i = 0; i < this._miListaDeSonidosComentarioDeNoGol_Longitud; i++)
//        {

//            // Crear la Lista
//            //
//            this._miListaDelayPlaySonidoNoGol_WaitForSeconds[ i ] = new WaitForSeconds( this._miListaDeSonidosComentarioDeNoGol[i].length );

//        }//End for


//        // 3-   Corrutina de:   _miSonidoComentario_Blooper_AlEntrarEnFaseDeSuddenDeath      ============================================

//        // Crear el "return" de la Corrutina:
//        //
//        this._miSonidoComentario_Blooper_AlEntrarEnFaseDeSuddenDeath_WaitForSeconds = new WaitForSeconds( this._miSonidoComentario_Blooper_AlEntrarEnFaseDeSuddenDeath.length );


//        // 3-   Corrutina de:   _miSonidoComentario_Blooper_AlEntrarEnFaseDeSuddenDeath      ============================================

//        // Crear el "return" de la Corrutina:
//        //
//        this._miScriptCamaraParaAnimacionAlGanarOPerderEnfocarMuchosPuntosYMoverseAMuchosDestinos_movermeAhora_WaitUntil = new WaitUntil(() => (! this._miScriptCamaraParaAnimacionAlGanarOPerderEnfocarMuchosPuntosYMoverseAMuchosDestinos._movermeAhora));


//        #endregion Corrutinas - Optimizacion

//    }//End Method Awake



//    /// <summary>
//    /// Configures this App's initial parameters.
//    /// </summary>
//    private void ConfigureAppInitialParameters()
//    {

//        #region Configuration Settings del Dispositivo

//        // Celular NO se DUERMA, ni se apague la pantalla durante el juego por no tocar la pantalla un cierto tiempo:
//        //
//        Screen.sleepTimeout = SleepTimeout.NeverSleep;

//        #endregion Configuration Settings del Dispositivo


//        #region Configuracion del Juego

//        // Variable para pausar inicialmente el Juego, a fin de esperar por confirmación via GUI para poder iniciar.
//        //..Intenta resolver un Bug con DESAPARICIÓN DEL BALÓN, que ocurre cuando se pierde el RECONOCIMIENTO DEL IMAGE MARKER con Vuforia,
//        //..y se vuelve a enfocar el mismo: la reanudación no ocurre de manera grácil con el Balón, sí con los demás elementos (Portero, Escenario, etc.).
//        // 
//        //
//        //this._appEstaPausada.AddListener(delegate { UpdatearValorMicrofonoSensibilidadReconocedorDeSonidos(); });
//        //
//        // Inicializacion:
//        //
//        this._appCambiarDeEstadoTogglePauseODespause = true;    // Pedir un cambio de PAUSA-DESPAUSA.
//        this._appEstaPausada = true;                            // Pedir: PAUSAR.
//        //
//        // NO: Poner acá (PORQUE LO HARÉ EN EL final del Start() de este Script) una: Pausa a Todos los Niveles: GUI + Lógico:  ""PausarODespausarGeneralJuego( TRUE )""


//        // Variables finales a inicializar dentro del UPDATE, como primer y único paso una sola vez 
//        //...(ésta es la BANDERA / FLAG que se encargará de asegurar que se ejecute 1 vez):
//        //
//        this._gameStateWhenPlaying = _GAME_STATES_WHEN_PLAYING.InicializacionFinalVariables;


//        #region Debug.Logs

//        // Apagar todos los LOGS de PLUGINS + mi propio código:
//        //
//#if !DEVELOPMENT_BUILD && !UNITY_EDITOR

//        // Release BUILD o PLAYMODE (UNITY_EDITOR) de prueba:
//        //
//        //Debug.Log("I will NOT print this in a DEVELOPMENT_BUILD.\nNot in PlayMode of Unity3D, either");
//        //
//        //////Debug.Log("I will NOT print this in a DEVELOPMENT_BUILD. Maybe in the UNITY EDITOR YEAH");

//        // Apagar OBLIGADO todos los LOGS de PLUGINS + mi propio código:
//        //
//        this._verDebugLogsWarningsErrors = false;
//        //
//        //Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);    // Se puede setear para cada tipo: LogType.Assert, LogType.Error, etc
//#endif


//        // Apagar o Encender: todos los LOGS de PLUGINS + mi propio código:
//        //
//        Debug.unityLogger.logEnabled = this._verDebugLogsWarningsErrors;     //false;
//        //
//        //Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);    // Se puede setear para cada tipo: LogType.Assert, LogType.Error, etc

//        #endregion Debug.Logs


//        #region Render - Graphics

//        // 1- Resolver el bug del ""Depth Render"" Shadows, una vez que se activa la opción en la CÁMARA: 
//        //...(nunca solucionado por UNITY3D), sí está solucionado en el nuevo GRAPHICS RENDER PIPELINE DEL 2018.3.
//        // Explicación: Enabling 'DepthNormals' on the Camera, causes Unity to not batch any draw-call during UpdateDepthNormalsTexture 
//        //...in Forward Rendering. Batching does work in DeferredRendering though. I submitted a bug-report a while ago for this issue: 
//        //...(Case 924489) Draw-call batching not working during UpdateDepthNormalsTexture

//        // -> https://forum.unity.com/threads/poor-performance-of-updatedepthtexture-why-is-it-even-needed.197455/
//        //    Camera.main.depthTextureMode = DepthTextureMode.None;
//        //
//        this._miCamaraRealDeLaApp.depthTextureMode = DepthTextureMode.None;


//        // 2- VSYNC  y  3- Setear una correcta RESOLUCION DE PANTALLA (i.e.: que permita ahorrar RAM, trabajo de GPU y  trabajo de CPU...),
//        // ...acorde a variables pasadaas como parámetros de entrada a esta clase (GameManager.cs).
//        //
//        // Sólo si la PLATAFORMA (OS) es de un "LOW - END DEVICE": ANDROID, iOS o TV:
//        //
//        if ( (Application.isMobilePlatform) || (Application.platform == RuntimePlatform.Android) || (Application.platform == RuntimePlatform.IPhonePlayer) /*|| (Application.platform == RuntimePlatform.SamsungTVPlayer)*/ || (Application.platform == RuntimePlatform.WSAPlayerARM) || (Application.platform == RuntimePlatform.WSAPlayerX86) || (Application.platform == RuntimePlatform.WSAPlayerX64) || (Application.platform == RuntimePlatform.WindowsEditor) || (Application.platform == RuntimePlatform.LinuxEditor) || (Application.platform == RuntimePlatform.OSXEditor) )
//        {

//            // 2- VSYNC: The number of VSyncs that should pass between each frame. 
//            // .. Use 'Don't Sync' (0) to not wait for VSync. Value must be 0, 1 (Dysplay - Monitor o Pantalla default: 60 Hz <=> 60 FPS), 2 (la mitad, 30 Hz / FPS), 3, or 4.
//            //
//            // Sync framerate to ‘don’t’ sync’ refresh rate
//            //
//            ///// NUEVO CÓDIGO: No haré un seteo del SYNC por esta via (debido a que VUFORIA A.R.: LO HACE, vSYNC a 30 FPS capeado..., no voy a interferir con eso), solamente a través de las opciones del Editor:  setearé No vSync (lo cual será igualmente alterado con los Scripts de inicialización de Vuforia):
//            //
//            QualitySettings.vSyncCount = 0;   //2;     // 2 <=> Este Valor lo capea a 30 FPS
//            //
//            ///// VIEJO CÓDIGO: QualitySettings.vSyncCount = 0; // No sincronizar nada. Libertad.


//            // 3-   Setear una CALIDA "MEDIA" FIJADA POR MI:
//            //
//            this.SetearConfiguracionGraficaGlobalSegunPoderDeDispositivo( _MI_FPS_CONSTANTE_MOBILE /* FPS FIJADO para estos sistemas */, this._miCalidadDeQualitySettings /* Se HEREDARÁ del INSPECTOR */ /*_CALIDAD_DE_QUALITY_SETTINGS.MEDIUM */  /* .MEDIUM = 2 */ );


//        }//End if (Application.platform == RuntimePlatform.Android)
//        //
//        else    // Hablamos de un MID - END y HIGH - END device: Windows, Linux, Mac PC, o CONSOLAS DE JUEGOS (PS, PS2, PS3, PS4, Nintendo Switch, etc...)
//        {

//            // 2- VSYNC: The number of VSyncs that should pass between each frame. 
//            // .. Use 'Don't Sync' (0) to not wait for VSync. Value must be 0, 1 (Dysplay - Monitor o Pantalla default: 60 Hz <=> 60 FPS), 2 (la mitad, 30 Hz / FPS), 3, or 4.
//            //
//            // Sync framerate to ‘don’t’ sync’ refresh rate
//            //
//            ///// NUEVO CÓDIGO: No haré un seteo del SYNC por esta via (debido a que VUFORIA A.R.: LO HACE, vSYNC a 30 FPS capeado..., no voy a interferir con eso), solamente a través de las opciones del Editor:  setearé No vSync (lo cual será igualmente alterado con los Scripts de inicialización de Vuforia):
//            //
//            QualitySettings.vSyncCount = 1;     // Este Valor lo capea a 60 FPS
//            //
//            ///// VIEJO CÓDIGO: QualitySettings.vSyncCount = 0; // No sincronizar nada. Libertad.


//            // 3-   Setear una CALIDA MEDIA hacia: "ALTA" FIJADA POR MI:
//            //
//            this.SetearConfiguracionGraficaGlobalSegunPoderDeDispositivo( _MI_FPS_CONSTANTE_STANDALONE /* FPS FIJADO para estos sistemas */, _CALIDAD_DE_QUALITY_SETTINGS.NON_INITIALIZED_INHERIT_FROM_ABOVE_METHODS /* Se HEREDARÁ de un MENÚ PRINCIPAL o del INSPECTOR */ );


//        }//End Else del if (Application.platform == RuntimePlatform.Android || (Application.platform == RuntimePlatform.IPhonePlayer) || (Application.platform == RuntimePlatform.SamsungTVPlayer) || (Application.platform == RuntimePlatform.WSAPlayerARM) || (Application.platform == RuntimePlatform.WSAPlayerX86) || (Application.platform == RuntimePlatform.WSAPlayerX64) )


//        #endregion Render - Graphics

//        #endregion Configuracion del Juego


//        #region Physics 2D - Fisica 2D

//        // Apagar la Física 2D:
//        //
//        Physics2D.autoSimulation = false;

//        #endregion Physics 2D - Fisica 2D


//        #region Camera Settings

//        // Apagar Occlusion Culling
//        //
//        if ( this._miCamaraRealDeLaApp.useOcclusionCulling )
//        {

//            this._miCamaraRealDeLaApp.useOcclusionCulling = false;

//        }//End if ( this._miCamara.useOcclusionCulling )

//        #endregion Camera Settings


//        /// Buscando obtener por debugueo todos los Scripts de cierto tipo:  ConductaMovimientoBasicoIzqDer[] myScriptObjects = FindObjectsOfType( typeof(ConductaMovimientoBasicoIzqDer)) as ConductaMovimientoBasicoIzqDer[];

//        ///// Optimizando, no va: //Debug.Log("OJO: RECORDATORIO:\n *** No olvidar continuar actualizando los parámetros iniciales de la App, para que sea ÓPTIMA");

//    }//End Method ConfigurarParametrosApp()



//    /// <summary>
//    /// Start this instance. Executes itself once. It executes when this Script is Enabled.
//    /// </summary>
//    void Start ()
//    {

//        // Desactiva el Reconocedor de Sonidos:
//        //
//        ///// Comentado porque se mejoró (VER ABAJO LA MEJORA):  this._miMicrophoneInputDelBalon.canRecognizeSoundsNow = false;
//        //
//        this._miMicrophoneInputDelBalon.DesactivarYesconder();


//        #region Garbage Collection

//        // Inicializa un HEAP GRANDE de basura:
//        //
//        /////_miGarbageCollectionManager.InicializarHeapAllocGrande();


//        #endregion Garbage Collection


//        #region Configuracion del Juego

//        //  DIFICULTAD
//        //
//        this.InicializarDificultadDelJuego();

//        #endregion

//        #region Preparacion de Juego para empezar con A.R.

//        // SÍ: Poner acá una: Pausa a Todos los Niveles: GUI + Lógico:  
//        //
//        this.PausarODespausarGeneralJuego( this._appEstaPausada );

//        #endregion


//    }//End Method Start




//    /// <summary>
//    /// Update this instance, it is executed once in each frame.
//    /// </summary>
//    void Update()
//    {

//        /////Profiler.BeginSample("ddd GameManager.Update() General");

//        //// PAUSÓ el Juego:
//        ////
//        //if ( this._appCambiarDeEstadoTogglePauseODespause )
//        //{

//        //    //1 - Cada vez que haya una PÉRDIDA DE DETECCIÓN DEL MARKER: Se PAUSARÁ!        
//        //    //->
//        //    //Todo a continuación estará dentro de un Método llamado:
//        //    //->
//        //    //""PausarODespausarGeneralJuego(TRUE o FALSE ahora será this._appEstaPausada )""


//        //    // Activar pausa o despausar
//        //    //
//        //    this.PausarODespausarEscalaDeTiempo( this._appEstaPausada );

//        //    // Salir
//        //    //
//        //    return;

//        //    // Display el Boton para REANUDAR EL JUEGO, seguir jugando:
//        //    //
//        //    //....
//        //    //this._mainGameState = _GAME_STATES.GameOver;

//        //    // DEPENDIENDO DEL ESTADO de la otra variable (e.g.: ""_GAME_STATES_WHEN_PLAYING""), sabremos QUÉ hacer.
//        //    //
//        //    //if ( _GAME_STATES_WHEN_PLAYING.mmm)
//        //    //{
//        //    //}//
//        //    //else { }
//        //    //etc...........

//        //}//End if


//        #region Game State / Fases de Juego

//        switch (_mainGameState)
//        {
            
//            case _GAME_STATES.Playing:
//            //{         

//                // FASE 0 (solo se ejecutará una vez):  Inicializar variables después que las de TODOS los SCRIPTS lo han hecho:
//                //
//                ///// if (this._gameStateWhenPlaying == _GAME_STATES_WHEN_PLAYING.InicializacionFinalVariables)
//                switch (this._gameStateWhenPlaying)
//                {

//                    case _GAME_STATES_WHEN_PLAYING.InicializacionFinalVariables:
//                    //{

//                        #region Configuracion del Juego

//    //                        //  DIFICULTAD
//    //                        //
//    //                        this.InicializarDificultadDelJuego();

//                        // RE-Inicializar objectos, si el jugador solicitó PLAY AGAIN (después de haber perdido/ganado una PARTIDA ANTERIOR):
//                        //

//                        // Habilitar Balón (enable):
//                        //
//                        // No usar esto, porque omite la SOMBRA CUSTOM del Balon: this._miPlayer.SetActive(true);
//                        // Mejorado
//                        //
//                        this._miMicrophoneInputDelBalon._miConductaBalon.ActivarYmostrar();


//                        //OJO: SI SE DESEA USAR 'CAMARA LENTA GLOBAL' SE DEBE COMENTAR (no eliminar, ''por si acaso'') LAS
//                        // LINEAS QUE DICEN:    this.IniciarOTerminarCamaraLenta(
//                        //
//                        // Setear velocidad a CAMARA LENTA, para todo el juego:
//                        //                        //
//                        //                        if (this._usarCamaraLentaGlobal)
//                        //                        {
//                        //                            this.CambiarVelocidadDePasoDelTiempoGlobal( this._miVelocidadDelTiempoGlobal );
//                        //
//                        //                        }//end if (this._usarCamaraLentaGlobal)


//                        // Garbage Collection: Aviso que en este ESTADO sí puedo Limpiar la GARBAGE:
//                        //
//                        this._puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance = true;

//                        #endregion Configuracion del Juego


//                        // BORRAR O COMENTAR cuando haga BUILD-DEPLOY FINAL:
//                        //
//                        /////Debug.Log("GameManager.cs -> Update()\n->\nRESOLUCION DE PANTALLA APLICADA AL FINAL: Screen.currentResolution = " + Screen.currentResolution);
//                        //
//                        //                            // Resoluciones existentes:
//                        //                            //
//                        //                            int longRes = Screen.resolutions.Length;
//                        //                            //
//                        //                            /////Debug.Log("GameManager.cs -> RESOLUCIONES DISPONIBLES para este OS:\n->\n");
//                        //                            //
//                        //                            for ( int i = 0; i < longRes; i++ )
//                        //                            {
//                        //
//                        //                                //Debug.Log(i + " )-- " + Screen.resolutions[ i ].ToString() );
//                        //
//                        //                            }//End for

//                        //////BORRAR DESPUES O COMENTARRRRR:::::::://///////////////
//                        //
//                        //Debug.Log("QUALITY SETTINGS FIJADOS (mi variable): this._miCalidadDeQualitySettings = " + this._miCalidadDeQualitySettings);
//                        //Debug.Log("QUALITY SETTINGS FIJADOS: QualitySettings.GetQualityLevel() = " + QualitySettings.GetQualityLevel());
//                        //Debug.Log("QUALITY SETTINGS FIJADOS: QualitySettings.names[ QualitySettings.GetQualityLevel() ] = " + QualitySettings.names[QualitySettings.GetQualityLevel()]);
//                        //Debug.Log("FPS fijados: = " + Application.targetFrameRate);
//                        //
//                        ///FIN DE:///BORRAR DESPUES O COMENTARRRRR:::::::://///////////////


//                        // Fin de esta ETAPA INICIALIZATORIA:
//                        //
//                        // Marcar paso a siguiente FASE 1: Preparando Variables para Empezar a Chutar (RE-INICIALIZACION)
//                        //
//                        this._gameStateWhenPlaying = _GAME_STATES_WHEN_PLAYING.PreparandoVariablesParaChutar;

//                        break;
                    
//                    //}//End if (this._gameStateWhenPlaying == _GAME_STATES_WHEN_PLAYING.InicializacionFinalVariables)
//                //
//                //
//                // FASE 1:  Inicializar (o REINICIALIZAR) Variables para poder Chutar otro Penalty.
//                //
//                //else if (this._gameStateWhenPlaying == _GAME_STATES_WHEN_PLAYING.PreparandoVariablesParaChutar)
//                //
//                case _GAME_STATES_WHEN_PLAYING.PreparandoVariablesParaChutar:
//                    //
//                    //{

//                    // 0- Activar el Garbage Collector (si estaba apagado) y hacer una LIMPIEZA INICIAL.. luego apagar.
//                    //
//                    // 1- ACTIVAR Controles para el Chute: 
//                    //   1.1- MIC de Voz Input (está en Objeto PLAYER de este Script, ó BALON en el HIERARCHY).
//                    //   1.2- 1.2- DES-Activar la I.A. de Chute automático.
//                    //
//                    // 2- Activar movimientos (update) de personajes del Juego:
//                    //   2.1- ACTIVAR Portero (INVOCAR SU SCRIPT DESDE SU OBJETO EN ""PUBLIC"" ACÁ)
//                    //   2.2- ACTIVAR BalonIndicadorParaApuntar (INVOCAR SU SCRIPT DESDE SU OBJETO EN ""PUBLIC"" ACÁ)
//                    //	 2.3- Ubicar en su lugar al BALON (en la LINEA DE META/GOL).
//                    //   2.4- Setear la Posicion de la Cámara.
//                    //
//                    // 3- Preparar otras variables para esta FASE.


//                    // Inicio:
//                    //
//                    // 0- Activar el Garbage Collector (si estaba apagado) y hacer una LIMPIEZA INICIAL.. luego apagar.
//                    //
//                    _miGarbageCollectionManager.EnableGC_CleanGC();
//                    //
//                    // Garbage Collection: Aviso que en este ESTADO sí puedo Limpiar la GARBAGE:
//                    //
//                    this._puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance = true;



//                    // 1- ACTIVAR Controles para el Chute: 
//                    //   1.1- MIC de Voz Input (está en Objeto PLAYER de este Script, ó BALON en el HIERARCHY).
//                    //
//                    // Decidir si Dispara: 1- P1 o.. 2- CPU
//                    //
//                    if (this._miJugadorActualQueChuta == this._miJugadorUNO)
//                    {

//                        // Toca chutar: P1 (Player 1: Humano)
//                        // ACCIONES:
//                        //
//                        // 1- ACTIVAR Controles para el Chute del HUMANO, mientras Desactivas el del CPU: 
//                        //   1.1- MIC de Voz Input (está en Objeto PLAYER de este Script, ó BALON en el HIERARCHY).
//                        //      (Se Activará el MIC dos FASES más adelante, para CHUTAR).
//                        //
//                        //   1.2- DES-Activar la I.A. de Chute automático:
//                        //
//                        this._miScriptConductaIAChutadorDelPenalty.enabled = false;

//                        // 2- Activar movimientos (update) de personajes del Juego:
//                        //   2.1- ACTIVAR Portero CPU (INVOCAR SU SCRIPT DESDE SU OBJETO EN ""PUBLIC"" ACÁ)
//                        //
//                        this._miScriptConductaPorteroCPU.ReinicializarActivarYmostrar();
//                        //
//                        //   Esconder Portero Humano:
//                        //
//                        this._miScriptControlPortero2D.DesactivarYesconder();

//                        //   2.2- ACTIVAR BalonIndicadorParaApuntar (INVOCAR SU SCRIPT DESDE SU OBJETO EN ""PUBLIC"" ACÁ)
//                        //
//                        this._miScriptConductaBalonIndicadorParaApuntar.ReinicializarActivarYmostrar();

//                        //   2.4- Setear la Posicion de la Cámara.
//                        //
//                        this._miScriptCamaraEnfocarUnPuntoYMoverseADestinoChutar.enabled = true;
//                        this._miScriptCamaraEnfocarUnPuntoYMoverseADestinoChutar._movermeAhora = true;
//                        //
//                        this._miScriptCamaraEnfocarUnPuntoYMoverseADestinoPortear._movermeAhora = false;
//                        this._miScriptCamaraEnfocarUnPuntoYMoverseADestinoPortear.enabled = false;


//                    }//end if ( this._miJugadorActualQueChuta == this._miJugadorUNO )
//                    //
//                    else      // ( this._miJugadorActualQueChuta == this._miJugadorUNO )
//                    {

//                        // Toca chutar: CPU (Player 2)
//                        // ACCIONES:
//                        //
//                        // 1- DESACTIVAR Controles para el Chute del HUMANO, mientras activas el del CPU: 
//                        //   1.1- MIC de Voz Input (está en Objeto PLAYER de este Script, ó BALON en el HIERARCHY).
//                        //
//                        //  (COMENTAR porque ya está hecho): Des-Activa el Reconocedor de Sonidos: Ya está hecho desde antes:  this._miMicrophoneInputDelBalon.canRecognizeSoundsNow = false;
//                        //
//                        //   1.2- Activar la I.A. de Chute automático:
//                        //
//                        this._miScriptConductaIAChutadorDelPenalty.enabled = true;

//                        // 2- Activar movimientos (update) de personajes del Juego:
//                        //
//                        //   Esconder Portero CPU:
//                        //
//                        this._miScriptConductaPorteroCPU.DesactivarYesconder();

//                        //   2.2- DESACTIVAR BalonIndicadorParaApuntar (INVOCAR SU SCRIPT DESDE SU OBJETO EN ""PUBLIC"" ACÁ)
//                        //
//                        this._miScriptConductaBalonIndicadorParaApuntar.DesactivarYesconder();

//                        //   2.1- ACTIVAR Portero Humano (INVOCAR SU SCRIPT DESDE SU OBJETO EN ""PUBLIC"" ACÁ)
//                        //
//                        this._miScriptControlPortero2D.ReinicializarActivarYmostrar();

//                        //   2.4- Setear la Posicion de la Cámara.
//                        //
//                        this._miScriptCamaraEnfocarUnPuntoYMoverseADestinoChutar._movermeAhora = false;
//                        this._miScriptCamaraEnfocarUnPuntoYMoverseADestinoChutar.enabled = false;
//                        this._miScriptCamaraEnfocarUnPuntoYMoverseADestinoPortear.enabled = true;
//                        this._miScriptCamaraEnfocarUnPuntoYMoverseADestinoPortear._movermeAhora = true;

//                    }//end else del if
//                    //
//                    //   2.3- Ubicar en su lugar al BALON (en la LINEA DE META/GOL).
//                    //
//                    this._miScriptLineaDeGol.ReubicarElBalonEnPuntoDePenalty();


//                    // 3- Preparar otras variables para esta FASE.
//                    //
//                    // Mostrar la GUI
//                    //
////                      // ELIMINADO: Optimización de RAM / CPU.
//                    //
////                        this._miTiempoGUICanvas.SetActive(true);
//                    //
//                    // Mostrar GUI de Ronda:
//                    //
//                    /////2018/11/08: GASTABA MUCHO CPU: PICOS de demasiado trabajo del CPU: this._miRoundTandaGUICanvas.SetActive(true);
//                    // OPTIMIZADO V2:
//                    //
//                    this.ActivarDesactivarVisibilidadCanvasDeLetrasRoundX(true);
//                    //
//                    this.ActivarAnimacionAleatoriaDeLetrasRoundX();


//                    // Mostrar GUI de Score Goles Final:                       
//                    //
//                    /////OPTIMIZADO V2: ESTO NO ERA BUENO, GASTABA MUCHO CPU Y GENERABA HIPOS EN LA APP:    this._miGUIContenedoraDeScoreGolesAnotadosTextos.SetActive(true);
//                    // MEJORADO V2:
//                    //
//                    // ES BUENO, PERO NO ES NECESARIO (ya está visible): this.ActivarDesactivarVisibilidadCanvasDeLetrasScoreResultanteGoles(true);


//                    // Limpiar la GUI de Goles Anotados:
//                    // 23/10/2018: Comentado, para implementar una mejora, a fin de optimizar el trabajo de CPU y GPU. 
//                    //..Además se permite el BATCHING porque todos los "Globos de Gol grises" tendrán el mismo MATERIAL Código original: this.LimpiarGUIdeGolesAnotados_v2();
//                    //
//                    this.LimpiarGUIdeGolesAnotados_v3();

//// Eliminado del Proyecto. Sustituido por:  LETRAS DE ORO Y PLATA DE GOAL.//
////                        // Esconder GUI de GOOOL!
////                        //
////                        this._miGolGUICanvas.SetActive(false);
////                        //
////                        // Esconder GUI de NO GOOOL!
////                        //
////                        this._miNoGolGUICanvas.SetActive(false);


//                    // Bandera de ""Falta reproducir sonido de Comentarista"":
//                    //
//                    this._faltaReproducirSonidoDeGol = true;
//                    //
////                        // Detener (STOP) Sonidos de Animacion del Portero:
////                        //
////yyy                        this.StopSonidoAnimacionPortero();
//                    //
//                    // Setear a DEFAULT el estado de las animaciones que se repiten cada vez
//                    // Animacion de PLANO DE LETRAS DE GOAL:
//                    //
//                    /////this._miScriptAnimacionesLetrasEnPantalla.InicializarAnimacionPlanoLetrasOroGoalAEstadoDefaultIdle();


//                    // Resetear tiempo:
//                    //
//                    this._miTiempo = 0.0f;

////                        // Resetear Animaciones de 'Meter/Fallar GOOOL':
////                        // DEFAULT:
////                        //
////                        this._miAnimatorPorteroPlayerP1.SetTrigger( _PORTERO_IDLE_TRIGGER_PARAMETER_ANIMATION_STATE_HASH );
////                        //
////                        this._miAnimatorPorteroCPU.SetTrigger( _PORTERO_IDLE_TRIGGER_PARAMETER_ANIMATION_STATE_HASH );


//                    // Chequear si el Turno es el # 6: (Inicio de: SUDDEN DEATH):
//                    //
//                    if ((this._numeroOrdinalDeTurnoJugadorUNO == (this._NUMERO_DE_TURNOS_POR_TANDA + 1)) && (this._numeroOrdinalDeTurnoJugadorUNO == this._numeroOrdinalDeTurnoJugadorCPU))
//                    {

//                        // Round/Tanda 6, por PRIMERA VEZ: SUDDEN DEATH.

//                        // Garbage Collection: Aviso que en este ESTADO NO puedo Limpiar la GARBAGE:
//                        //
//                        this._puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance = false;


//                        // Marcar paso a siguiente FASE 7: ANIMACION de SUDDEN DEATH ("Muerte Súbita"):
//                        //
//                        this._gameStateWhenPlaying = _GAME_STATES_WHEN_PLAYING.AnimacionInicioSuddenDeath;

//                    }//end if
//                    else
//                    {
//                        // Cualquier número de Round/TANDA, normal (no es Sudden Death):

//                        // Garbage Collection: Aviso que en este ESTADO NO puedo Limpiar la GARBAGE:
//                        //
//                        this._puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance = false;


//                        // Marcar paso a siguiente FASE 2: ANIMACION INICIAL QUE DICE:   RONDA 1 (ó X).
//                        //
//                        this._gameStateWhenPlaying = _GAME_STATES_WHEN_PLAYING.EsperandoPorGUIRoundNumero;

//                    }//end else del if


//                    //// Si NO ESTA PAUSADA, puede apagarse el GC AUTOMATICO:
//                    ////
//                    //if (!this._appEstaPausada)
//                    //{

//                    // ZZ- Des-Activar el Garbage Collector (si estaba Encendido).
//                    //
//                    _miGarbageCollectionManager.DisableGC();
//                    //
//                    // Actualizar el Timer de Limpieza, a CERO:
//                    //
//                    this._miTiempoParaInvocarGCCollect = 0.0f;

//                    //}//End if ( !this._appEstaPausada )

//                    // Anunciar que se pasó por esta FASE:
//                    //
//                    ////////Debug.Log("1- EN FASE 1: INICIALIZANDO ('PreparandoVariablesParaChutar'): para Chutar a Porteria (pero aún no)");

//                    break;

//                //}//end else if
//			//
//			// FASE 2: ANIMACION INICIAL QUE DICE:   RONDA 1 (ó X):
//			//
//            case _GAME_STATES_WHEN_PLAYING.EsperandoPorGUIRoundNumero:
//                //
//                //
//                //else if (this._gameStateWhenPlaying == _GAME_STATES_WHEN_PLAYING.EsperandoPorGUIRoundNumero)
//                //{

//                // Conteo del Tiempo de Juego (Animacion):
//                //
//                this._miTiempo += Time.deltaTime;


////                        // ELIMINADO: Por OPTIMIZACIÓN DE RAM / CPU.
////                        //
////                        this._miTiempoGUIText.text = "" + this._miTiempo.ToString("0");

//                    // Terminó la FASE actual?
//                    //
//                    if ((this._miTiempo >= _TIEMPO_MAXIMO_ANIMACION_TANDA_RONDA_GUI) || (this._terminarAbruptamenteDeContarMiTiempoEntreFases))
//                    {

//                        // Terminar con la Animacion
//                        //
//                        this._miTiempo = 0.0f;

////                        // ELIMINADO: Por OPTIMIZACIÓN DE RAM /CPU.
////                            this._miTiempoGUIText.text = "" + this._miTiempo.ToString("0");
//                        //
//                        // Poner en FALSO la Bandera de 'cortar abruptamente el conteo':
//                        //
//                        this._terminarAbruptamenteDeContarMiTiempoEntreFases = false;

//                        // Esconder la GUI
//                        //
//                        /////this._miTiempoGUICanvas.SetActive( false );
//                        //
//                        // Esconder GUI de Ronda:
//                        //
//                        /////2018/11/08: GASTABA MUCHO CPU: PICOS HORRIBLES en el PROFILER: this._miRoundTandaGUICanvas.SetActive(false);
//                        // OPTIMIZADO V2:
//                        //
//                        this.ActivarDesactivarVisibilidadCanvasDeLetrasRoundX(false);
//                        //
//                        /////Se debe apagar la Animacion ésta, OJO verificar que esté apagado el DOTWEEN de ésto: this.ActivarAnimacionAleatoriaDeLetrasRoundX();


//                        // Decidir si Dispara: 1- P1 o.. 2- CPU
//                        //
//                        if (this._miJugadorActualQueChuta == this._miJugadorUNO)
//                        {

//                            // Jugador UNO
//                            //
//                            // Activa el Reconocedor de Sonidos:
//                            //
//                            ///// COMENTADO PORQUE SE desarrolló una mejora (ver mejora más abajo):
////                            this._miMicrophoneInputDelBalon.enabled = true;
////                            this._miMicrophoneInputDelBalon.canRecognizeSoundsNow = true;
//                            //
//                            // Mejora a lo de arriba:
//                            //
//                            this._miMicrophoneInputDelBalon.ReinicializarActivarYmostrar();


//                        }//end if ( this._miJugadorActualQueChuta == this._miJugadorUNO )
//                    else
//                        {
//                            // Jugador CPU
//                            //
//                            // Activa la Bandera de I.A.: Pude CHUTAR YA!:
//                            //
//                            this._miScriptConductaIAChutadorDelPenalty.ReinicializarActivarYmostrar();


//                            // Activar CÁMARA LENTA, debido a que el PLAYER = PORTERO
//                            // ..esto dará más oportunidad de "diversión" y un "reto" más accesible.
//                            //
//                            this.IniciarOTerminarCamaraLenta(true);

//                        }//end else del if ( this._miJugadorActualQueChuta == this._miJugadorUNO )


//                        // Ejecutar SONIDO: Silbato (SILBATAZO) DEL ÁRBITRO para disparar!
//                        //
//                        /// Optimizacion: No usar Métodos para cosas de una LÍNEA - TRIVIALES:  this.PlaySonidoSilbatazoCobrarPenalty();
//                        //
//                        // Play Silbatazo!:
//                        //
//                        this._miAudioSourceSilbatazos.PlayOneShot( this._miSonidoSilbatazoCobrarPenalty );


//                        //   Ubicar en su lugar (con velocidad CERO, inmovil) al BALON (en la LINEA DE META/GOL).
//                        //
//                        this._miScriptLineaDeGol.ReubicarElBalonEnPuntoDePenalty();


//                        // Garbage Collection: Aviso que en este ESTADO NO puedo Limpiar la GARBAGE:
//                        //
//                        this._puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance = false;


//                        // Anunciar que se pasó por esta FASE:
//                        //
//                        ////////Debug.Log("2- EN FASE 2: ANIMACION INICIAL QUE DICE:   RONDA 1 (ó X)");


//                        // Marcar el INICIO de la siguiente FASE:
//                        //
//                        this._gameStateWhenPlaying = _GAME_STATES_WHEN_PLAYING.PorChutar;


//                    }//end if ( this._miTiempo >= _TIEMPO_MAXIMO_ANIMACION_TANDA_RONDA_GUI )

//                    break;

//                //}
//			//
//			//FASE 3:  Esperando por el CHUTE del jugador (cuando el usuario lo decida):
//			//
//            case _GAME_STATES_WHEN_PLAYING.PorChutar:
//            //
//			    //else if (this._gameStateWhenPlaying == _GAME_STATES_WHEN_PLAYING.PorChutar)
//                //{

//                    // 1- Esperar a que el usuario dispare. Acá no habrá acciónes. Solo ESPERA a que entre en la siguiente etapa.
//                    // Eso activará un Trigger tarde o teprano. Puede ocurrir:
//                    //   1.1- GOL <=> Balon cruce LINA DE META (habrá un Script llamado ""LineaDeMeta"" que disparará un TRIGGER 
//                    //      y encenderá la bandera: ""_GAME_STATES_WHEN_PLAYING.CelebracionGol"")
//                    //
//                    //   1.2- No Gol <=> Balon cruce ""Area imaginaria"" (invisible) más exterior a la Porteria y al Escenario. 
//                    //      Eso encenderá la Bandera: ""_GAME_STATES_WHEN_PLAYING.CelebrandoNoEsGol"",
//                    //
//                    //   ..y al activarse las banderas arriba mencionadas: pasará al ""else if"" de abajo (GOL - NO GOL).
//                    //
//                    // 2- Activar/resetear un CONTADOR DE TIEMPO: Medirá cúanto tiempo tarda el jugador para "cobrar el penalty".
//                    //    2.1- Cada 5 segundos ocurrirá presión sobr el jugador: 
//                    //		2.1.1- Árbitro pitará y se oirá la voz del mismo diciendo (en inglés): ""Dispara ya, no te demores o te saco una tarjeta amarilla!"".
//                    //		  Después de eso, se reseteará el TIMER de nuevo y se repite la historia (2) completa.
//                    //
//                    // 3- Preparar otras variables para esta FASE.


//                    // Inicio:

//                    // 2- Activar/resetear un CONTADOR DE TIEMPO: Medirá cúanto tiempo tarda el jugador para "cobrar el penalty".
//                    //    2.1- Cada 5 segundos ocurrirá presión sobr el jugador: 
//                    //		2.1.1- Árbitro pitará y se oirá la voz del mismo diciendo (en inglés): ""Dispara ya, no te demores o te saco una tarjeta amarilla!"".
//                    //		  Después de eso, se reseteará el TIMER de nuevo y se repite la historia (2) completa.
//                    // Conteo del Tiempo de Juego (Animacion):
//                    //
//                    this._miTiempo += Time.deltaTime;

////                        // ELIMINADO: Por OPTIMIZACIÓN DE RAM /CPU.
//                    //
////                        this._miTiempoGUIText.text = "" + this._miTiempo.ToString("0");

//                    // Anunciar que se pasó por esta FASE:
//                    //
//                    ////////Debug.Log("3- EN FASE 3: Para Chutar a Porteria\n CHUUUTA YA!");

//                //}//end else if

//                break;

//			//
//			//FASE 4:  CHUTANDO (YA DISPARÓ!): El Balon está volando hacia la Porteria... Aún no cruzó las ""Línea de Meta"" o ""Línea de Fin del Ambiente"".
//			//
//                case _GAME_STATES_WHEN_PLAYING.Chutando:
//            //
//			//else if (this._gameStateWhenPlaying == _GAME_STATES_WHEN_PLAYING.Chutando)
//                //{

//                    // 1- DESACTIVAR Controles para el Chute: 
//                    //   1.1- MIC de Voz Input (está en Objeto PLAYER de este Script, ó BALON en el HIERARCHY).
//                    //   1.2- 
//                    //
//                    // 2- DESACTIVAR movimientos (update) de personajes del Juego:
//                    //   2.1- DESACTIVAR Portero (INVOCAR SU SCRIPT DESDE SU OBJETO EN ""PUBLIC"" ACÁ)
//                    //   2.2- DESACTIVAR BalonIndicadorParaApuntar (INVOCAR SU SCRIPT DESDE SU OBJETO EN ""PUBLIC"" ACÁ)
//                    //	 2.3- DESACTIVAR todo el TIMER o CONTADOR DE TIEMPO (para que ya no presione a través de la GUI al jugador a disparar).
//                    //
//                    // 3- Preparar otras variables para esta FASE.


//                    // Inicio:

//                    // 1- DESACTIVAR Controles para el Chute: 
//                    //   1.1- MIC de Voz Input (está en Objeto PLAYER de este Script, ó BALON en el HIERARCHY).
           
//                    // 2- DESACTIVAR movimientos (update) de personajes del Juego:
//                    //   2.1- DESACTIVAR Portero (INVOCAR SU SCRIPT DESDE SU OBJETO EN ""PUBLIC"" ACÁ)
//                    //

//                    // Decidir si Dispara: 1- P1 o.. 2- CPU
//                    //
////                    if ( this._miJugadorActualQueChuta == this._miJugadorUNO )
////                    {
////
////                        // Jugador UNO
////                        //
////                        //   2.2- DESACTIVAR BalonIndicadorParaApuntar (INVOCAR SU SCRIPT DESDE SU OBJETO EN ""PUBLIC"" ACÁ)
////                        //
////                        this._miScriptConductaBalonIndicadorParaApuntar.DesactivarYesconder();
////
////                    }//end if ( this._miJugadorActualQueChuta == this._miJugadorUNO )
////                    else
////                    {
////                        // Jugador CPU
////                        //
////                        //   2.2- DESACTIVAR BalonIndicadorParaApuntar (INVOCAR SU SCRIPT DESDE SU OBJETO EN ""PUBLIC"" ACÁ)
////                        //
////                        // No es necesario en este caso: this._miScriptConductaBalonIndicadorParaApuntar.DesactivarYesconder();
////
////                    }//end else del if ( this._miJugadorActualQueChuta == this._miJugadorUNO )


//                    //	 2.3- DESACTIVAR todo el TIMER o CONTADOR DE TIEMPO (para que ya no presione a través de la GUI al jugador a disparar).
//                    //
//                    this._miTiempo = 0.0f;

////                        // ELIMINADO: Por OPTIMIZACIÓN DE RAM / CPU.
//                    //
////                      this._miTiempoGUIText.text = "" + this._miTiempo.ToString("0");
//                    //
//                    // Esconder la GUI
//                    //
//                    /////this._miTiempoGUICanvas.SetActive(false);

//                    // Anunciar que se pasó por esta FASE:
//                    //
//                    ////////Debug.Log("4- EN FASE 4: CHUTANDO (YA DISPARÓ!)");

//                //}//end else if

//                break;

//			//
//			//FASE 5.1:  Es: GOOOL!
//			//
//                case _GAME_STATES_WHEN_PLAYING.CelebracionGol:
//            //
//			//else if (this._gameStateWhenPlaying == _GAME_STATES_WHEN_PLAYING.CelebracionGol)
//                //{
//                    // 1- La pelota cruzó la ""LÍNEA DE META"",... de GOL!
//                    // Eso activará un Trigger tarde o temprano (que proviene de otros SCRIPTS: En la (a) ""LINEA DE META""; o en (b) ""LIMITE DEL ESCENARIO"").
//                    // Ocurrió:
//                    //   1.1- GOL <=> Balon cruce LINA DE META (habrá un Script llamado ""LineaDeMeta"" que dispararó un TRIGGER 
//                    //      y encendió la Bandera: ""_GAME_STATES_WHEN_PLAYING.CelebracionGol"")
//                    //
//                    // 2- ACTIVAR la ANIMACION: GOOOL!
//                    //
//                    // 3- ANOTAR (en Variables de acá + en la GUI refrescada):
//                    //   3.1- TURNO nuevo.
//                    //	 3.2- GOL
//                    //	 3.3- PUNTOS XP
//                    //	 3.4- PUNTOS-ORO del Juego.
//                    //
//                    // X- Verificar con variables de ANIMACION (o incluso de TIMER): Que se haya acabado la animación, y pasar a la siguiente FASE:

//                    // Inicio:
//                    //

//                    // Conteo del Tiempo de Juego (Animacion):
//                    //
//                    this._miTiempo += Time.deltaTime;

////                        // ELIMINADO: Por OPTIMIZACIÓN DE RAM / CPU.
//                    //
////                        this._miTiempoGUIText.text = "" + this._miTiempo.ToString("0");


//                    // 2- ACTIVAR la ANIMACION: GOOOL!

//                    // Eliminado del Proyecto. Sustituido por:  LETRAS DE ORO Y PLATA DE GOAL.//
////                        //
////                        // Temporal: GUI de GOOOL!
////                        //
////                        this._miGolGUICanvas.SetActive(true);

//                    //////////////////////

//                    // No se ha tomado Nota del GOL:
//                    //
//                    if (this._faltaTomarNotaDelGolReciente)
//                    {

//                        // Desplegar SONIDOS del juego:
//                        //
//                        if (this._faltaReproducirSonidoDeGol)
//                        {

//                            // Terminar la Cámara Lenta. poner en Velocidad NORMAL:
//                            //
//                            this.IniciarOTerminarCamaraLenta(false);


//                            // Esconder GUI de Score Goles Final:
//                            //
//                            /////OPTIMIZADO V2: ESTO NO ERA BUENO, GASTABA MUCHO CPU Y GENERABA HIPOS EN LA APP:    this._miGUIContenedoraDeScoreGolesAnotadosTextos.SetActive(false);
//                            // MEJORADO V2:
//                            //
//                            // OPTIMIZADO: NO HACER INVISIBLE - VISIBLE: porque gasta mucho %CPU:  this.ActivarDesactivarVisibilidadCanvasDeLetrasScoreResultanteGoles(false);
//                            // Mostrar ANIMACION (Tween) de SCORE GOLes, ejemplo: (1 - 0):
//                            //
//                            this.IniciarAnimacionAleatoriaDeLetrasScoreResultanteGoles();


//                            // Iniciar la Animación de Personajes (baile, morisquetas, etc) debido al Chute-GOL!
//                            //
//                            this.IniciarAnimacionDePorteroAlDetenerUnGolEleccionAleatoria();
//                            //
//                            // Inactivar objeto del Control-Joystick, para evitar BUGS:
//                            //
//                            // * Comentado: 2018/11/15: Antes fue:    this._miScriptControlPortero2D.ActivarODesactivarControlDelJugador(false);
//                            // OPTIMIZADO:  
//                            //
//                            this._miScriptControlPortero2D.ActivarODesactivarControlDelJugadorOptimizadoV2(false);
//                            //
//                            // INICIAR LA ANIMACIÓN DE lETRAS DE oro: goal!
//                            //
//                            this._miScriptAnimacionesLetrasEnPantalla.IniciarAnimacionPlanoLetrasOroGoal_1_Inicial();


//                            // Comentarista grita GOOOL:
//                            //
//                            StartCoroutine(this.PlaySonidoGolNoGolV2());

//                            // Sonido de Bulla-GOOOL del Público:
//                            //
//                            this.PlaySonidoAleatorioBullaDeGooolOAbucheo(true);


//                            // Garbage Collection: Aviso que en este ESTADO NO puedo Limpiar la GARBAGE:
//                            //
//                            this._puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance = false;


//                        }//end if (this._faltaReproducirSonidoDeGol)


//                        // Si pasó 1/4 de segundo: Tomar nota del GOL para mostrarlo inteligentemente por Pantalla:
//                        //
//                        if (this._miTiempo > this._TIEMPO_MAXIMO_EMPEZAR_TOMAR_NOTA_DEL_GOL)
//                        {

//                            // Mostrar GUI de Score Goles Final:
//                            //
//                            /////OPTIMIZADO V2: ESTO NO ERA BUENO, GASTABA MUCHO CPU Y GENERABA HIPOS EN LA APP:    this._miGUIContenedoraDeScoreGolesAnotadosTextos.SetActive(true);
//                            // MEJORADO V2:
//                            //
//                            // OPTIMIZADO: NO HACER INVISIBLE - VISIBLE: porque gasta mucho %CPU:  this.ActivarDesactivarVisibilidadCanvasDeLetrasScoreResultanteGoles(true);
//                            //
//                            // Mostrar ANIMACION (Tween) de SCORE GOLes, ejemplo: (1 - 0):
//                            //
//                            ///MOVIDO MAS ARRIBA: this.IniciarAnimacionAleatoriaDeLetrasScoreResultanteGoles();


//                            // Decidir si Dispara: 1- P1 o.. 2- CPU
//                            //
//                            if (this._miJugadorActualQueChuta == this._miJugadorUNO)
//                            {

//                                // Jugador UNO
//                                //
//                                // 3- ANOTAR (en Variables de acá + en la GUI refrescada):
//                                //   3.1- TURNO nuevo.
//                                //   3.2- GOL
//                                //
//                                // COMENTADO EL 16/03/2018. MEJORA ABAJO (LIMPIA EL PANEL DE COLOR GRIS DE GOLES AL INICIAR TANDA): this.ActualizarGolDeEsteTurno( this._numeroOrdinalDeTurnoPenalty, true, false);
//                                // Comentado 24/10/2018: Mejora abajo: GUI optimizada al evitar cambiar de imagen de GLOBO DE GOL, se cambia de color usando 1 solo SPRITE. Codigo original: this.ActualizarGolDeEsteTurno(this._numeroOrdinalDeTurnoJugadorUNO, true, true, true, true);
//                                //
//                                this.ActualizarGolDeEsteTurno_v3(this._numeroOrdinalDeTurnoJugadorUNO, true, true, true, true);

//                                //   3.3- PUNTOS XP
//                                //   3.4- PUNTOS-ORO del Juego.
//                                //
//                                this.GanarPuntosOroYExperienciaSinMostrarEnGUI(this._puntosDeOroAlMeterGOL, this._puntosDeExperienciaXPGol);


//                                // Apagar la Bandera que permitió entrar acá:
//                                //
//                                this._faltaTomarNotaDelGolReciente = false;


//                            }//end if ( this._miJugadorActualQueChuta == this._miJugadorUNO )
//                        else
//                            {
//                                // Jugador CPU
//                                //

//                                // 3- ANOTAR (en Variables de acá + en la GUI refrescada):
//                                //   3.1- TURNO nuevo.
//                                //   3.2- GOL
//                                //
//                                // COMENTADO EL 16/03/2018. MEJORA ABAJO (LIMPIA EL PANEL DE COLOR GRIS DE GOLES AL INICIAR TANDA): this.ActualizarGolDeEsteTurno( this._numeroOrdinalDeTurnoPenalty, true, false);
//                                // Comentado 24/10/2018: Mejora abajo: GUI optimizada al evitar cambiar de imagen de GLOBO DE GOL, se cambia de color usando 1 solo SPRITE. Codigo original: this.ActualizarGolDeEsteTurno(this._numeroOrdinalDeTurnoJugadorCPU, true, true, true, true);
//                                //
//                                this.ActualizarGolDeEsteTurno_v3(this._numeroOrdinalDeTurnoJugadorCPU, true, true, true, true);

//                                //   3.3- PUNTOS XP
//                                //   3.4- PUNTOS-ORO del Juego.
//                                //
//                                this.GanarPuntosOroYExperienciaSinMostrarEnGUI(this._puntosDeOroAlMeterGOL, this._puntosDeExperienciaXPGol);


//                                // Apagar la Bandera que permitió entrar acá:
//                                //
//                                this._faltaTomarNotaDelGolReciente = false;


//                            }//end else del if ( this._miJugadorActualQueChuta == this._miJugadorUNO )

//                        }//End if ( this._miTiempo > this._TIEMPO_MAXIMO_EMPEZAR_TOMAR_NOTA_DEL_GOL )

//                    }//end if ( this._faltaTomarNotaDelGolReciente )

//                    //////////////////////

//                    // Terminó la FASE actual?
//                    //
//                    if (this._miTiempo >= (_TIEMPO_MAXIMO_ANIMACION_GOL + _TIEMPO_DELTA_OFFSET_DETENER_ANIMACION_GOL_Y_NO_GOL))
//                    {

//                        // Resetear el Tiempo:
//                        //
//                        // 1.2-     Detener el Contador de Tiempo:
//                        //
//                        this._miTiempo = 0.0f;

////                        // ELIMINADO: Por OPTIMIZACIÓN DE RAM / CPU.
////
////                            this._miTiempoGUIText.text = "" + this._miTiempo.ToString("0");


//                        // Apagar la Animacion (el ""estado agrandado y coloreado"") de las LETRAS DEL SCORE de GOL (va arriba en el medio):
//                        //
//                        this.TerminarAnimacionAleatoriaDeLetrasScoreResultanteGoles();


//                        // Detener Movimientos de la Cámara:
//                        //
//                        this._miScriptCamaraParaAnimacionDeGolOSalvadaEnfocarMuchosPuntosYMoverseAMuchosDestinos.enabled = false;

                                                                               
//                        // VER SI METIENDO GOL ESTE JUGADOR QUE CHUTA: GANARÍA EL JUEGO:
//                        //
//                        this._nombreDeJugadorQuePodriaGanarEnSiguienteTurno = this.EstimarLaPosibilidadDeGanarOPerderEnTurnoSiguiente();
//                        //
//                        //
//                        // Decidir a CUÁL FASE ir a continuación:   INICIO o ANIMACIÓN de PELIGRO.
//                        //
//                        if (this._nombreDeJugadorQuePodriaGanarEnSiguienteTurno != _JUGADORES.NINGUNO)
//                        {

//                            // Marcar paso a siguiente FASE 6: ANIMACION DE ""PELIGRO"", que ocurre "a veces": Cuando el Juego podría terminar si meten/fallan el siguiente Penalty.
//                            //
//                            this._gameStateWhenPlaying = _GAME_STATES_WHEN_PLAYING.EsperandoPorAnimacionPeligroDeTerminarJuego;

//                            //Avisar que falta ejecutar Animacion:
//                            //
//                            this._faltaReproducirSonidoComentarioCuandoJuegoEstaEnPeligroDeTerminar = true;


//                            // Garbage Collection: Aviso que en este ESTADO NO puedo Limpiar la GARBAGE:
//                            //
//                            this._puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance = false;


//                        }//End if (this._nombreDeJugadorQuePodriaGanarEnSiguienteTurno != _JUGADORES.NINGUNO)
//                        else
//                        {

//                            // Garbage Collection: Aviso que en este ESTADO SÍ puedo Limpiar la GARBAGE:
//                            //
//                            this._puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance = true;


//                            // Marcar paso a siguiente FASE 1: Preparando Variables para Empezar a Chutar (RE-INICIALIZACION)
//                            //
//                            this._gameStateWhenPlaying = _GAME_STATES_WHEN_PLAYING.PreparandoVariablesParaChutar;


//                        }//End del else del if (this._nombreDeJugadorQuePodriaGanarEnSiguienteTurno != _JUGADORES.NINGUNO)

//                    }//end if ( this._miTiempo >= _TIEMPO_MAXIMO_ANIMACION_TANDA_RONDA_GUI )
//                    //
//                    // Terminó la animación SOLAMENTE ? (NO FASE actual)
//                    //
//                    else if (this._miTiempo >= _TIEMPO_MAXIMO_ANIMACION_GOL)
//                    {

//                        // 1.1-     Terminar con la Animacion de GOOOL!
//                        //          Poner Animaciones en ESTADO 'DEFAULT':
//                        //
//                        // Resetear Animaciones de 'Meter/Fallar GOOOL':
//                        // DEFAULT:
//                        //
//                        this.InicializarAnimacionDePorterosAEstadoDefaultIdle();


//                        // Esconder la GUI
//                        //
//// Eliminado del Proyecto. Sustituido por:  LETRAS DE ORO Y PLATA DE GOAL.//
////                            // 2- ACTIVAR la ANIMACION: GOOOL!
////                            // Temporal: GUI de GOOOL!
////                            //
////                            this._miGolGUICanvas.SetActive(true);

//                    }//end if ( this._miTiempo >= _TIEMPO_MAXIMO_ANIMACION_TANDA_RONDA_GUI )


//                    // Anunciar que se pasó por esta FASE:
//                    //
//                    ////////Debug.Log("5.1- EN FASE 5.1: Hay un GOOOL!");

//                //}//end else if

//                break;

//			//
//			// FASE 5.2: NO fue Gol.
//			//
//            case _GAME_STATES_WHEN_PLAYING.CelebracionNoEsGol:
//            //
//			//else if (this._gameStateWhenPlaying == _GAME_STATES_WHEN_PLAYING.CelebracionNoEsGol)
//                //{
//                    // 1- La pelota NO cruzó la ""LÍNEA DE META"",... de GOL. 
//                    // ... Pero SÍ CRUZÓ una DE DOS OPCIONES:
//                    //  (a) -> ""LÍNEA DE FIN DE ESCENARIO/AMBIENTE"" que disparó un TRIGGER (dentro del Script del Objeto ""LÍNEA DE FIN DE ESCENARIO/AMBIENTE""),
//                    // ... el cual encendió la Bandera ""_GAME_STATES_WHEN_PLAYING.CelebrandoNoEsGol"".
//                    // ... Ahora, por eso: Entró acá (este IF...).
//                    //
//                    //  (b) -> ""COLISIÓN contra OBJETO 'PORTERO'"" (sin colisionar contra ""LÍNEA DE META""): 
//                    //  que disparó un TRIGGER (dentro del Script del Objeto ""LÍNEA DE FIN DE ESCENARIO/AMBIENTE""),
//                    // ... el cual encendió la Bandera ""_GAME_STATES_WHEN_PLAYING.CelebrandoNoEsGol"".
//                    // ... Ahora, por eso: Entró acá (este IF...).
//                    //
//                    // 2- ACTIVAR la ANIMACION: BUUUU! No fue Gol!
//                    //
//                    // 3- ANOTAR (en Variables de acá + en la GUI refrescada):
//                    //   3.1- TURNO nuevo.
//                    //	 3.2- NO sumar GOLes.
//                    //	 3.3- PUNTOS XP (poquito: +1)
//                    //	 3.4- PUNTOS-ORO del Juego (poquito: +1).
//                    //
//                    // X- Verificar con variables de ANIMACION (o incluso de TIMER): Que se haya acabado la animación, y pasar a la siguiente FASE:

//                    // Inicio:
//                    //

//                    // Conteo del Tiempo de Juego (Animacion):
//                    //
//                    this._miTiempo += Time.deltaTime;

////                        // ELIMINADO: Por OPTIMIZACIÓN DE RAM / CPU.
//                    //
////                        this._miTiempoGUIText.text = "" + this._miTiempo.ToString("0");

//                    // 2- ACTIVAR la ANIMACION: NO - GOOOL!

//                    // Eliminado del Proyecto. Sustituido por:  LETRAS DE ORO Y PLATA DE GOAL.//
//                    //
////                        // Temporal: GUI de NO - GOOOL!
////                        //
////                        this._miNoGolGUICanvas.SetActive(true);


//                    // No se ha tomado Nota del GOL:
//                    //
//                    if (this._faltaTomarNotaDelGolReciente)
//                    {

//                        // Desplegar SONIDOS del juego:
//                        //
//                        if (this._faltaReproducirSonidoDeGol)
//                        {

//                            // Terminar la Cámara Lenta. poner en Velocidad NORMAL:
//                            //
//                            this.IniciarOTerminarCamaraLenta(false);


//                            // Iniciar la Animación de Personajes (baile, morisquetas, etc) debido al Chute-PARADA-NO-GOL!
//                            //
//                            this.IniciarAnimacionDePorteroAlDetenerUnGolEleccionAleatoria();
//                            //
//                            // Inactivar objeto del Control-Joystick, para evitar BUGS:
//                            // * Comentado: 2018/11/15: Antes fue:    this._miScriptControlPortero2D.ActivarODesactivarControlDelJugador(false);
//                            // OPTIMIZADO:  
//                            //
//                            this._miScriptControlPortero2D.ActivarODesactivarControlDelJugadorOptimizadoV2(false);


//                            // Grito de No-Goool (abucheo):
//                            //
//                            StartCoroutine(this.PlaySonidoGolNoGolV2());
//                            //
//                            // Sonido de Bulla (abucheo):
//                            //
//                            this.PlaySonidoAleatorioBullaDeGooolOAbucheo(false);


//                            // Garbage Collection: Aviso que en este ESTADO NO puedo Limpiar la GARBAGE:
//                            //
//                            this._puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance = false;


//                        }//end if (this._faltaReproducirSonidoDeGol)


//                        // Si pasó 1/4 de segundo: Tomar nota del NO-GOL para mostrarlo inteligentemente por Pantalla:
//                        //
//                        if (this._miTiempo > this._TIEMPO_MAXIMO_EMPEZAR_TOMAR_NOTA_DEL_GOL)
//                        {

//                            // Decidir si Dispara: 1- P1 o.. 2- CPU
//                            //
//                            if (this._miJugadorActualQueChuta == this._miJugadorUNO)
//                            {

//                                // Jugador UNO
//                                //
//                                // 3- ANOTAR (en Variables de acá + en la GUI refrescada):
//                                //   3.1- TURNO nuevo.
//                                //   3.2- NO sumar GOLes.
//                                //
//                                // COMENTADO EL 16/03/2018. MEJORA ABAJO (LIMPIA EL PANEL DE COLOR GRIS DE GOLES AL INICIAR TANDA): this.ActualizarGolDeEsteTurno( this._numeroOrdinalDeTurnoPenalty, false, false );
//                                // Comentado 24/10/2018: Mejora abajo: GUI optimizada al evitar cambiar de imagen de GLOBO DE GOL, se cambia de color usando 1 solo SPRITE. Codigo original: this.ActualizarGolDeEsteTurno(this._numeroOrdinalDeTurnoJugadorUNO, false, true, true, true);
//                                //
//                                this.ActualizarGolDeEsteTurno_v3(this._numeroOrdinalDeTurnoJugadorUNO, false, true, true, true);

//                                //   3.3- PUNTOS XP
//                                //   3.4- PUNTOS-ORO del Juego.
//                                //
//                                this.GanarPuntosOroYExperienciaSinMostrarEnGUI(this._puntosDeOroAlFallarElChute, this._puntosDeExperienciaXPFallandoElChute);


//                                // Apagar la Bandera que permitió entrar acá:
//                                //
//                                this._faltaTomarNotaDelGolReciente = false;


//                            }//end if ( this._miJugadorActualQueChuta == this._miJugadorUNO )
//                        else
//                            {
//                                // Jugador CPU
//                                //

//                                // 3- ANOTAR (en Variables de acá + en la GUI refrescada):
//                                //   3.1- TURNO nuevo.
//                                //   3.2- NO sumar GOLes.
//                                //
//                                // COMENTADO EL 16/03/2018. MEJORA ABAJO (LIMPIA EL PANEL DE COLOR GRIS DE GOLES AL INICIAR TANDA): this.ActualizarGolDeEsteTurno( this._numeroOrdinalDeTurnoPenalty, false, false );
//                                // Comentado 24/10/2018: Mejora abajo: GUI optimizada al evitar cambiar de imagen de GLOBO DE GOL, se cambia de color usando 1 solo SPRITE. Codigo original: this.ActualizarGolDeEsteTurno(this._numeroOrdinalDeTurnoJugadorCPU, false, true, true, true);
//                                //
//                                this.ActualizarGolDeEsteTurno_v3(this._numeroOrdinalDeTurnoJugadorCPU, false, true, true, true);

//                                //   3.3- PUNTOS XP
//                                //   3.4- PUNTOS-ORO del Juego.
//                                //
//                                this.GanarPuntosOroYExperienciaSinMostrarEnGUI(this._puntosDeOroAlFallarElChute, this._puntosDeExperienciaXPFallandoElChute);


//                                // Apagar la Bandera que permitió entrar acá:
//                                //
//                                this._faltaTomarNotaDelGolReciente = false;


//                            }//end else del if ( this._miJugadorActualQueChuta == this._miJugadorUNO )

//                        }//End if ( this._miTiempo > this._TIEMPO_MAXIMO_EMPEZAR_TOMAR_NOTA_DEL_GOL )

//                        //////////////////////////////

//                    }//end if
//                    //
//                    // Terminó la FASE actual?
//                    //
//                    if (this._miTiempo >= (_TIEMPO_MAXIMO_ANIMACION_NO_GOL + _TIEMPO_DELTA_OFFSET_DETENER_ANIMACION_GOL_Y_NO_GOL))
//                    {

//                        // Resetear el Tiempo:
//                        //
//                        this._miTiempo = 0.0f;

////                        // ELIMINADO: Por OPTIMIZACIÓN DE RAM / CPU.
//                        //
////                            this._miTiempoGUIText.text = "" + this._miTiempo.ToString("0");

//                        // Detener Movimientos de la Cámara:
//                        //
//                        this._miScriptCamaraParaAnimacionDeGolOSalvadaEnfocarMuchosPuntosYMoverseAMuchosDestinos.enabled = false;


//                        // VER SI METIENDO GOL ESTE JUGADOR QUE CHUTA: GANARÍA EL JUEGO:
//                        //
//                        this._nombreDeJugadorQuePodriaGanarEnSiguienteTurno = this.EstimarLaPosibilidadDeGanarOPerderEnTurnoSiguiente();


//                        // Decidir a CUÁL FASE ir a continuación:   INICIO o ANIMACIÓN de PELIGRO.
//                        //
//                        if (this._nombreDeJugadorQuePodriaGanarEnSiguienteTurno != _JUGADORES.NINGUNO)
//                        {

//                            // Marcar paso a siguiente FASE 6: ANIMACION DE ""PELIGRO"", que ocurre "a veces": Cuando el Juego podría terminar si meten/fallan el siguiente Penalty.
//                            //
//                            this._gameStateWhenPlaying = _GAME_STATES_WHEN_PLAYING.EsperandoPorAnimacionPeligroDeTerminarJuego;
//                            //
//                            this._faltaReproducirSonidoComentarioCuandoJuegoEstaEnPeligroDeTerminar = true;


//                            // Garbage Collection: Aviso que en este ESTADO NO puedo Limpiar la GARBAGE:
//                            //
//                            this._puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance = false;


//                        }//End if (this._nombreDeJugadorQuePodriaGanarEnSiguienteTurno != _JUGADORES.NINGUNO)
//                        else
//                        {

//                            // Garbage Collection: Aviso que en este ESTADO SÍ puedo Limpiar la GARBAGE:
//                            //
//                            this._puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance = true;


//                            // Marcar paso a siguiente FASE 1: Preparando Variables para Empezar a Chutar (RE-INICIALIZACION)
//                            //
//                            this._gameStateWhenPlaying = _GAME_STATES_WHEN_PLAYING.PreparandoVariablesParaChutar;


//                        }//End del else del if (this._nombreDeJugadorQuePodriaGanarEnSiguienteTurno != _JUGADORES.NINGUNO)


//                    }//end if ( this._miTiempo >= _TIEMPO_MAXIMO... )
//                    //
//                    // Terminó la ANIMACIÓN ?  (NO FASE actual)
//                    //
//                    if (this._miTiempo >= _TIEMPO_MAXIMO_ANIMACION_NO_GOL)
//                    {

//                        // Terminar con la Animacion
//                        //
//                        // 0-  Poner Animaciones en ESTADO 'DEFAULT':
//                        //
//                        // Resetear Animaciones de 'Meter/Fallar GOOOL':
//                        // DEFAULT:
//                        //
//                        this.InicializarAnimacionDePorterosAEstadoDefaultIdle();

//                        // Esconder la GUI
//                        // 2- ACTIVAR la ANIMACION: NO-GOOOL!

//                        // Eliminado del Proyecto. Sustituido por:  LETRAS DE ORO Y PLATA DE GOAL.//
//                        //
////                            // Temporal: GUI de NO-GOOOL!
////                            //
////                            this._miNoGolGUICanvas.SetActive(true);

                                                                                          
//                    }//end if ( this._miTiempo >= _TIEMPO_... )


//                    // Anunciar que se pasó por esta FASE:
//                    //
//                    ////////Debug.Log("5.2- EN FASE 5.2: NO fue Gol :(");

//                //}//end else if
//                //

//                break;

//                //
//                // FASE 6: ANIMACION DE ""PELIGRO"", que ocurre "a veces": Cuando el Juego podría terminar si meten/fallan el siguiente Penalty.
//                //
//                case _GAME_STATES_WHEN_PLAYING.EsperandoPorAnimacionPeligroDeTerminarJuego:
//                //
//                //else if (this._gameStateWhenPlaying == _GAME_STATES_WHEN_PLAYING.EsperandoPorAnimacionPeligroDeTerminarJuego)
//                //{

//                    // Sonido de: 'I CAN FEEL THE PRESSURE RAISING UP!'
//                    //
//                    if ((!this._miAudioSourceComentarista.isPlaying))
//                    {

//                        // Reproducir Sonido:
//                        //
//                        if (this._faltaReproducirSonidoComentarioCuandoJuegoEstaEnPeligroDeTerminar)
//                        {

////                                // 0-   Detener (STOP) Sonidos de Animacion del Portero:
////                                //
////yyy                                this.StopSonidoAnimacionPortero();


//                            // 1-   Play Sonido al Ganar / o Perder:
//                            //
//                            this.PlaySonidoAleatorioComentarista(this._miListaDeSonidosComentariosCuandoJuegoEstaEnPeligroDeTerminar, this._miListaDeSonidosComentariosCuandoJuegoEstaEnPeligroDeTerminar_Longitud);
//                            //
//                            this._faltaReproducirSonidoComentarioCuandoJuegoEstaEnPeligroDeTerminar = false;


//                            // 2-   ANIMACIÓN:
//                            // INICIAR LA ANIMACIÓN (y dejar que ella sola termine por su propia cuenta), ... ó:
//                            // 
//                            // Variables de TIEMPO harán que la ANIMACIÓN aguante ESTE ESTADO acá, sin cambiar hasta que termine 
//                            //...(se pueden usar CORRUTINAS para ANIMACIONES estilo el GameManager.cs del juego de Sparty Bros., ),
//                            //... o si se usan Animaciones 100% dirigidas por SCRIPT: puedo usar un SCRIPT de TIMER para contarle el TIEMPO a esta FASE como hice con el caso de las FASES
//                            //...dentro del SCRIPT 'PorteroIA.cs'
//                            //
//                            this._miScriptCamaraParaAnimacionDePeligroEnfocarMuchosPuntosYMoverseAMuchosDestinos.Reinicializacion();


//                            // Garbage Collection: Aviso que en este ESTADO NO puedo Limpiar la GARBAGE:
//                            //
//                            this._puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance = false;


//                        }//End if (this._faltaReproducirSonidoComentarioCuandoJuegoEstaEnPeligroDeTerminar)
//                        else
//                        {

//                            // Lista la Animación!
//                            //
//                            if (!this._miScriptCamaraParaAnimacionDePeligroEnfocarMuchosPuntosYMoverseAMuchosDestinos.enabled)
//                            {

//                                // Se terminó la Animación:
//                                //
//                                // Garbage Collection: Aviso que en este ESTADO SÍ puedo Limpiar la GARBAGE:
//                                //
//                                this._puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance = true;


//                                // 3-   Fase siguiente:
//                                //
//                                // Marcar paso a siguiente FASE 1: Preparando Variables para Empezar a Chutar (RE-INICIALIZACION)
//                                //
//                                this._gameStateWhenPlaying = _GAME_STATES_WHEN_PLAYING.PreparandoVariablesParaChutar;

//                            }//End if (! this._miScriptCamaraParaAnimacionDePeligroEnfocarMuchosPuntosYMoverseAMuchosDestinos.enabled)

//                        }//End else del if

//                    }//End if (this._faltaReproducirSonidoAlFinalDeGanarOPerder)
////                        else
////                        {
////                        }//End else

//                //}//End else del if
//                //
//                break;

//                //
//                // FASE 7: ANIMACION DE INICIO DE ""SUDDEN DEATH"", que ocurre: Cuando inicia la TANDA de MUERTE SÚBITA final.
//                // OJO: Viene de FASE 1, previamente (Preparando Variables para Empezar a Chutar). Listas las variables:
//                //
//                case _GAME_STATES_WHEN_PLAYING.AnimacionInicioSuddenDeath:
//                //
//                //else if (this._gameStateWhenPlaying == _GAME_STATES_WHEN_PLAYING.AnimacionInicioSuddenDeath)
//                //{

//                    // Sonido de: 'Let's go to a Sudden Death!'
//                    //
//                    if ((!this._miAudioSourceComentarista.isPlaying))
//                    {

//                        // Reproducir Sonido:
//                        //
//                        if (this._faltaReproducirSonidoComentariosAlEntrarEnFaseDeSuddenDeath)
//                        {

////                                // 0-   Detener (STOP) Sonidos de Animacion del Portero:
////                                //
////yyy                                this.StopSonidoAnimacionPortero();


//                            // 1-   Play Sonido Comentarista:
//// Version 1.0, comentado el 2018/06/13                                //
////                                this.PlaySonidoAleatorioComentarista(this._miListaDeSonidosComentariosAlEntrarEnFaseDeSuddenDeath);
////                                //
////                                this._faltaReproducirSonidoComentariosAlEntrarEnFaseDeSuddenDeath = false;


//                            // Version 2.0: 2018/06/13. Por:    Alejandro.
//                            // Comentarista grita GOOOL:
//                            //
//                            StartCoroutine(this.PlaySonidoComentariosParaEntrarEnSuddenDeath());

////                                // 2-   ANIMACIÓN:
////                                // INICIAR LA ANIMACIÓN (y dejar que ella sola termine por su propia cuenta), ... ó:
////                                // 
////                                // Variables de TIEMPO harán que la ANIMACIÓN aguante ESTE ESTADO acá, sin cambiar hasta que termine 
////                                //...(se pueden usar CORRUTINAS para ANIMACIONES estilo el GameManager.cs del juego de Sparty Bros., ),
////                                //... o si se usan Animaciones 100% dirigidas por SCRIPT: puedo usar un SCRIPT de TIMER para contarle el TIEMPO a esta FASE como hice con el caso de las FASES
////                                //...dentro del SCRIPT 'PorteroIA.cs'
////                                //
////                                this._miScriptCamaraParaAnimacionDePeligroEnfocarMuchosPuntosYMoverseAMuchosDestinos.Reinicializacion();


//                            // Garbage Collection: Aviso que en este ESTADO NO puedo Limpiar la GARBAGE:
//                            //
//                            this._puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance = false;

//                        }//End if (this._faltaReproducirSonidoComentariosAlEntrarEnFaseDeSuddenDeath)
//                        else
//                        {

//                            // Lista la Animación!  (Si hubiera Animación)
//                            //
////                                if (! this._miScriptCamaraParaAnimacionDePeligroEnfocarMuchosPuntosYMoverseAMuchosDestinos.enabled)
////                                {
////
////                                    // Se terminó la Animación:
////                                    //
////                                    // 3-   Fase siguiente:
////                                    //
////                                    // Marcar paso a siguiente FASE 1: Preparando Variables para Empezar a Chutar (RE-INICIALIZACION)
////                                    //
////                                    this._gameStateWhenPlaying = _GAME_STATES_WHEN_PLAYING.EsperandoPorGUIRoundNumero;
////
////                                }//End if (! this._miScriptCamaraParaAnimacionDePeligroEnfocarMuchosPuntosYMoverseAMuchosDestinos.enabled)


//                            // Se terminó la Animación:
//                            //
//                            // 3-   Fase siguiente:
//                            // 
//                            // Encender Bandera que afirma que el 'conteo de tiempo' (con la frase: 'ROUND X') no es necesario
//                            // (porque sería demasiado tiempo esperando por el SILBATAZO del árbitro).
//                            //
//                            this._terminarAbruptamenteDeContarMiTiempoEntreFases = true;


//                            // Garbage Collection: Aviso que en este ESTADO NO puedo Limpiar la GARBAGE:
//                            //
//                            this._puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance = false;


//                            // Marcar paso a siguiente FASE 2: Preparando Variables para Empezar a Chutar (RE-INICIALIZACION)
//                            //
//                            this._gameStateWhenPlaying = _GAME_STATES_WHEN_PLAYING.EsperandoPorGUIRoundNumero;

//                        }//End else del if

//                    }//End if (this._faltaReproducirSonidoComentariosAlEntrarEnFaseDeSuddenDeath)
////                        else
////                        {
////                        }//End else

//                //}//End else del if

//                break;

//                default :
//				//else
//                //{

//                    // Anunciar que se pasó por un Estado no considerado:
//                    //
//                    Debug.LogError("CRITICO OJO: Pasó por un caso no considerado en el 'Switch - Case' del Game Manager. No es cubierto por la variable de estados: 'this._gameStateWhenPlaying'");

//                //}//end else

//                break;

//            }//End Switch 2 _GAME_STATES_WHEN_PLAYING

//        //}//End case estado ""PLAYING""
        
//		//////////////////End CASE estado PLAYING

//        break;

//        // Ganó el Juego:
//        //
//            case _GAME_STATES.BeatLevel:


//                // COMENTADO 2018/08/08:    Eliminado del Proyecto. Sustituido por:  LETRAS DE ORO Y PLATA DE GOAL.//
////                // GUI: actualizar
////                //
////                this._miRoundTandaGUIText_Numero.text = "FIN.\nHAS GANADO!";
////
////                // Mostrar GUI (TEMPORAL, porque acá se pondrá una Animación con sonidos estilo: HAS GANADO LA COPA MACUTO SHERATON!):
////                //
////                this._miRoundTandaGUICanvas.SetActive(true);

//                // Sonido de CONGRATULATIONS: GANANDO O PERDIENDO:
//                //
//                if ((!this._miAudioSourceComentarista.isPlaying) && this._faltaReproducirSonidoAlFinalDeGanarOPerder)
//                {

//                    // Play Sonido al Ganar / o Perder:
//                    //
//                    this.PlaySonidosGanarOPerderAlFinal();

//                    // Eliminado del Proyecto. Sustituido por:  LETRAS DE ORO Y PLATA DE GOAL.//
//                    //
////                    // Esconder GUI de GOOOL!
////                    //
////                    this._miGolGUICanvas.SetActive(false);
////                    //
////                    // Esconder GUI de NO GOOOL!
////                    //
////                    this._miNoGolGUICanvas.SetActive(false);


//// COMENTADO 2018/07/24: CÓDIGO MEJORADO MÁS ABAJO                   // INICIAR LA ANIMACIÓN DE lETRAS DE oro: WIN!
////                    //
////                    this._miScriptAnimacionesLetrasEnPantalla.IniciarAnimacionPlanoLetrasWINoLOSE_WIN_1_Inicial();
//                    //
//                    // Desplegar todas las animaciones (LETRAS 3D + CAMARA + RESULTADOS) de FIN DE JUEGO: WIN.
//                    //
//                    this.IniciarAnimacionDeFinDeJuego(true);


//                    // Setear el HECHO de haber GANADO:
//                    //
//                    this._miResultadoDelJuegoGaneOPerdi = true;
//                    //
//                    // Display la plantalla de GAME OVER, botones para seguir jugando:
//                    //
//                    this._mainGameState = _GAME_STATES.GameOver;

//                }//End if (this._faltaReproducirSonidoAlFinalDeGanarOPerder)



////                /////backgroundMusic.volume -= 0.01f;
////                if (backgroundMusic.volume<=0.0f) 
////                {
////                    AudioSource.PlayClipAtPoint (gameOverSFX,gameObject.transform.position);
////
////                    _mainGameState = _GAME_STATES.GameOver;
////                }

//                break;


//        // Perdió el Juego:
//        //
//            case _GAME_STATES.Death:

//                // COMENTADO 2018/08/08:    Eliminado del Proyecto. Sustituido por:  LETRAS DE ORO Y PLATA DE GOAL.//
////                // GUI: actualizar
////                //
////                this._miRoundTandaGUIText_Numero.text = "FIN.\nHAS PERDIDO!";
////
////                // Mostrar GUI (TEMPORAL, porque acá se pondrá una Animación con sonidos estilo: HAS ESTADO A PUNTO DE GANAR LA COPA MACUTO SHERATON!):
////                //
////                this._miRoundTandaGUICanvas.SetActive( true );


//                // Sonido de CONGRATULATIONS: GANANDO O PERDIENDO:
//                //
//                if ((!this._miAudioSourceComentarista.isPlaying) && this._faltaReproducirSonidoAlFinalDeGanarOPerder)
//                {

//                    // Play Sonido al Ganar / o Perder:
//                    //
//                    this.PlaySonidosGanarOPerderAlFinal();


//                    // Eliminado del Proyecto. Sustituido por:  LETRAS DE ORO Y PLATA DE GOAL.//
//                    //
////                    // Esconder GUI de GOOOL!
////                    //
////                    this._miGolGUICanvas.SetActive(false);
////                    //
////                    // Esconder GUI de NO GOOOL!
////                    //
////                    this._miNoGolGUICanvas.SetActive(false);


//// COMENTADO 2018/07/24:    Código mejorado ABAJO                    // INICIAR LA ANIMACIÓN DE lETRAS DE oro: goal!
////                    //
////                    this._miScriptAnimacionesLetrasEnPantalla.IniciarAnimacionPlanoLetrasWINoLOSE_LOSE_1_Inicial();
//                    //
//                    // CÓDIGO MEJORADO:
//                    // Desplegar todas las animaciones (LETRAS 3D + CAMARA + RESULTADOS) de FIN DE JUEGO: LOSE.
//                    //
//                    this.IniciarAnimacionDeFinDeJuego(false);


//                    // Setear el HECHO de haber PERDIDO:
//                    //
//                    this._miResultadoDelJuegoGaneOPerdi = false;
//                    //
//                    // Display la plantalla de GAME OVER, botones para seguir jugando:
//                    //
//                    this._mainGameState = _GAME_STATES.GameOver;

//                }//End if (this._faltaReproducirSonidoAlFinalDeGanarOPerder)


////                /////backgroundMusic.volume -= 0.01f;
////                if (backgroundMusic.volume<=0.0f) 
////                {
////                    AudioSource.PlayClipAtPoint (gameOverSFX,gameObject.transform.position);
////
////                    _mainGameState = _GAME_STATES.GameOver;
////                }

//                break;


//            //// Acaba de "DESPAUSAR" el Juego:
//            ////
//            //case _GAME_STATES.UnPaused:

//            //    // Display el Boton para REANUDAR EL JUEGO, seguir jugando:
//            //    //
//            //    //....
//            //    //this._mainGameState = _GAME_STATES.GameOver;

//            //break;

//            //			case _GAME_STATES.BeatLevel:
//            //				backgroundMusic.volume -= 0.01f;
//            //				if (backgroundMusic.volume<=0.0f) {
//            //					AudioSource.PlayClipAtPoint (beatLevelSFX,gameObject.transform.position);
//            //					
//            //					_mainGameState = _GAME_STATES.GameOver;
//            //				}
//            //				break;

//            //          case _GAME_STATES.Death:
//            //
//            //              backgroundMusic.volume -= 0.01f;
//            //              if (backgroundMusic.volume<=0.0f) 
//            //                {
//            //                  AudioSource.PlayClipAtPoint (gameOverSFX,gameObject.transform.position);
//            //
//            //                  _mainGameState = _GAME_STATES.GameOver;
//            //              }
//            //              break;

//            //			case _GAME_STATES.GameOver:
//            //				// nothing
//            //				break;

//            case _GAME_STATES.GameOver:

//                // Display menu de opciones: ''Re-play'' o ''Main Menu''.
//                //  OJOOO: ESTO ESTÁ MALLL: OPTIMIZARR (Esconder el "'COMPONENTE' CANVAS"! No el GameObject del 'Componente Canvas'...)
//                //
//                if (!this._miGameOverButtonsGUICanvas.activeInHierarchy)
//                {
//                    // Activar ""Botones simples de CANVAS UI V-2.0"":
//                    //
//                    this._miGameOverButtonsGUICanvas.SetActive(true);

//                    // Esconder la BARRA DE SENSIBILIDAD DEL MICRÓFONO:
//                    // Hacer INVISIBLE el elemento de GUI:
//                    //
//                    ///// 2018/11/16: OPTIMIZADO, VER CÓDIGO MEJORADO ABAJO. Código ORIGINAL: this._misCanvasComponentUIDelSliderReconocimientoDeSonidos.SetActive(false);
//                    //
//                    this.ActivarDesactivarGUISliderReconocimientoDeVozComponenteCanvas( false );
//                    //
//                    this._miSliderReconocimientoDeSonidos.enabled = false;

//                    // Hacer ""Kill"" de los Tweens/Secuencias, para evitar errores al hacer un RELOAD RE-PLAY:
//                    //
//                    this._miScriptTweensRoundX.DO_Kill_AllMyTweeners();
//                    this._miScriptTweensScoreAvsBv3.DO_Kill_AllMyTweeners();

//                }//End if
//                //
//                // COMENTADO 2018/08/08:    Eliminado del Proyecto. Sustituido por:  Botones simples de CANVAS UI V-2.0
//                //...
////                #region Control/Joystick sobre el Menu Principal
////
////                // Get input
////                //
////                if ( CrossPlatformInputManager.GetButtonDown("MainMenuButton") )
////                {
////
////                    this.PlaySonidoSilbatazoCobrarPenalty();
////
////                }//End if
////                else if ( CrossPlatformInputManager.GetButtonDown("PlayAgainButton") )
////                {
////
////                    this.PlaySonidoAnimacionPortero_CaerseParaAtras();
////
////                }//End if
////
////                #endregion Control/Joystick sobre el Menu Principal

//                // Música de fondo: Bajar primero el Volumen de la Gente de Background:
//                //
//                if ( this._miAudioSourceBullaGritosHumanosNormalConstante.volume > 0.0f )
//                {
//                    // Hacer que poco a poco la música de fondo aparezca, quitando la Bulla del Público:
//                    //
//                    this._miAudioSourceBullaGritosHumanosNormalConstante.volume -= 0.007f;

//                }//End if

//                // Hacer desaparecer y paralizar el Balón (cuando haya parado de hablar el Comentarista), para evitar Bugs raros:
//                //
//                if ((!this._miAudioSourceComentarista.isPlaying) && (this._miPlayer.activeInHierarchy))
//                {
//                    // Des-Habilitar Balón (disable):
//                    //
//                    ////NO, USAR METODOS COMPLETOS: this._miPlayer.SetActive(false)
//                    // Mejorado
//                    //
//                    this._miMicrophoneInputDelBalon._miConductaBalon.DesactivarYesconder();

//                    // 2.3- Ubicar en su lugar al BALÓN (en la LÍNEA DE META/GOL).
//                    //
//                    this._miScriptLineaDeGol.ReubicarElBalonEnPuntoDePenalty();

//                    // Ejecutar la MÚSICA DE GAMEOVER cuando finalmente se silencie al Público
//                    //
//                    if (( this._miAudioSourceBullaGritosHumanosNormalConstante.volume <= 0.0f ) && ( this._miAudioSourceBullaGritosHumanosNormalConstante.isActiveAndEnabled ))
//                    {

//                        // Apagar la canción/sonido previo: Bulla del Público:
//                        //
//                        this._miAudioSourceBullaGritosHumanosNormalConstante.Stop();
//                        this._miAudioSourceBullaGritosHumanosNormalConstante.enabled = false;


//                        // Reproducir Música de FONDO a Volumen establecido:
//                        // AudioSource.PlayClipAtPoint (gameOverSFX,gameObject.transform.position);
//                        //
//                        //this._miAudioSourceBullaGritosHumanosNormalConstante.PlayOneShot( this._miMusicClipMusicaBackgroundGameOver, 1.0f );
//                        //
//                        this._miAudioSourceBullaPublicoEmocionGol.PlayOneShot( this._miMusicClipMusicaBackgroundGameOver, 1.0f );
//                        //
//                        //this._miAudioSourceBullaPublicoEmocionGol.volume = 1.0f;
//                        //
//                        //Buena forma, pero deja el volumen muy bajo:  AudioSource.PlayClipAtPoint ( this._miMusicClipMusicaBackgroundGameOver, this._miCamara.transform.position, 1.0f );

//                        ////////Debug.LogWarning("++MUSICA++: ENTRÉ A LA PARTE DE GAMEOVER: EJECUTAR LA MUSICA FINAL..........");


//                        // Setear el estilo (PITCH en este caso) de la MÚSICA: SEGÚN SI GANÉ O PERDÍ:
//                        //
//                        if (this._miResultadoDelJuegoGaneOPerdi)
//                        {

//                            // GANÉ
//                            //
//                            this._miAudioSourceBullaPublicoEmocionGol.pitch = 1.0f;

//                        }//End if
//                        else
//                        {

//                            // PERDÍ
//                            //
//                            this._miAudioSourceBullaPublicoEmocionGol.pitch = 0.9f;

//                        }//End else del if (this._miResultadoDelJuegoGaneOPerdi)


//                        // Comentado porque se moverá a una implementación más general en el Update(), cerca del : case App.BackButtonPressed
//                        ////
//                        //// ZZ- RE-Activar el Garbage Collector (si estaba Apagado).
//                        ////
//                        //_miGarbageCollectionManager.EnableGC_NoCleanGC();
//                        ////
//                        //// Setear el TIEMPO DEL CRONOMETRO a CERO: Limpiaré la Memoria cada N-SEGUNDOS (Tentativamente 10.0f)
//                        ////
//                        //this._miTiempo = 0.0f;
//                        ////
//                        //// SÍ ACTIVAR la Limpieza cada N-segundos:
//                        ////
//                        //this._estaActivadoLimpiezaCadaNSegundosManual = true;

//                    }//En if (this._miAudioSourceBullaGritosHumanosNormalConstante.volume <= 0.0f ) 

//                }//End if ( ! this._miAudioSourceComentarista.isPlaying )


//                // Comentado porque se moverá a una implementación más general en el Update(), cerca del : case App.BackButtonPressed
//                //// Si estamos usando la GARBAGE COLLECTION cada N-SEGUNDOS:
//                ////
//                //if (this._estaActivadoLimpiezaCadaNSegundosManual)
//                //{

//                //    if (this._miTiempo < _CONSTANTE_TIEMPO_N_SEGUNDOS_INVOCAR_GC_COLLECT)
//                //    {

//                //        // Conteo del Tiempo ++ seg:
//                //        //
//                //        this._miTiempo += Time.deltaTime;

//                //    }
//                //    else    //Poner en cero, limpiar y empezar de nuevo:
//                //    {
//                //        // 1-Limpiar Basura de RAM:
//                //        //
//                //        _miGarbageCollectionManager.GCCollect();


//                //        // 2- Poner TIMER EN CERO otra vez.
//                //        //
//                //        this._miTiempo = 0.0f;

//                //    }//End if (this._miTiempo < 10.0f)

//                //}
//                ////else
//                ////{
//                ////}//End if (this._miTiempo < 10.0f)


//                break;

//		}//End Switch-Case


//        #endregion Game State / Fases de Juego


//        #region Botones Fisicos Movil

//        // Salir de la App, al presionar el boton BACK en Android, o ESCAPE (ESC) en PC:
//        //
//        if (Input.GetKeyDown(KeyCode.Escape))
//        {       
//            // Quitar la App:
//            //
//            Application.Quit();

//        }//End if

//        #endregion Botones Fisicos Movil



//        #region Update  Garbage Collection

//        // Mi GARBAGE COLLECTOR.
//        //
//        // Conteo del Tiempo ++ seg, DEL timer PARA LIMPIAR GC.COLLECT():
//        //
//        this._miTiempoParaInvocarGCCollect += Time.deltaTime;
//        //
//        // Guardar valor de MEMORY HEAP (GARBAGE):
//        //
//        this._miMemoriaHeapGarbageActual = System.GC.GetTotalMemory(false);
//        //
//        /////Debug.LogWarning("GAMEMANAGER GC : Memory used before collection (miGarbageActual KB): this._miMemoriaHeapGarbageActual = " + this._miMemoriaHeapGarbageActual);


//        // CADA x (3?) minutos : Limpiar la GARBAGE. //No esto (demasiadas preguntas, no): verificar si la MEMORIA del Heap (basura) es mayor a 36 MB.
//        //
//        if ( (this._miTiempoParaInvocarGCCollect > _CONSTANTE_TIEMPO_MINIMA_N_SEGUNDOS_PUEDE_INVOCAR_GC_COLLECT) && (this._miMemoriaHeapGarbageActual > _TAMANO_HEAP_GARBAGE_MINIMO_BYTES) )
//        {

//            /////Debug.LogWarning("GAMEMANAGER GC : A punto de: EVALUANDO MOMENTOS... ");


//            // Evaluando MOMENTOS 
//            // ..para poder LIMPIAR: (BUENO, MAL MOMENTO o EMERGENCIA WHATEVER)...
//            //
//            if ( this._puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance || (((_mainGameState == _GAME_STATES.Playing) && ((this._gameStateWhenPlaying ==
// _GAME_STATES_WHEN_PLAYING.InicializacionFinalVariables) || (this._gameStateWhenPlaying ==
// _GAME_STATES_WHEN_PLAYING.PreparandoVariablesParaChutar))) || (_mainGameState == _GAME_STATES.GameOver)) )
//            {
//                // Excelente Momento para LIMPIAR:
//                //
//                /////Debug.LogWarning("GAMEMANAGER GC : EVALUANDO MOMENTOS : Excelente Momento para LIMPIAR:  y  _miMemoriaHeapGarbageActual = " + _miMemoriaHeapGarbageActual);
//                //
//                // 1-Limpiar Basura de RAM:
//                //
//                _miGarbageCollectionManager.GCCollectApagandoGCautomatico();

//                // 2- Poner TIMER EN CERO otra vez. (En Ambos casos sirve: a- LIMPIADO: VOLVER A EMPEZAR .. b- NO LIMPIADO: Posponer).
//                //
//                this._miTiempoParaInvocarGCCollect = 0.0f;


//            }//End if ( this._puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance || ...
//             //            
//            else // 1- O no está en una FASE DE BAJO IMPACTO PERFORMANCE...
//                // 2- No es SUFICIENTEMENTE GRANDE el HEAP para limpiarlo: Posponer N-Segundos la Limpieza:
//            {


//                // Es una EMERGENCIA?  Puede ESPERAR?
//                //
//                if ((this._miMemoriaHeapGarbageActual > _TAMANO_HEAP_GARBAGE_MAXIMO_EMERGENCIA_BYTES) || (this._miTiempoParaInvocarGCCollect > _CONSTANTE_TIEMPO_MAXIMO_EMERGENCIA_N_SEGUNDOS_INVOCAR_GC_COLLECT))
//                {

//                    // Caso EXTREMO:  EMERGENCIA - URGENTE, LIMPIAR!
//                    //
//                    /////Debug.LogWarning("GAMEMANAGER GC : EVALUANDO MOMENTOS : Caso EXTREMO:  EMERGENCIA - URGENTE, LIMPIAR!");
//                    //
//                    // LIMPIAR!
//                    //
//                    _miGarbageCollectionManager.GCCollectApagandoGCautomatico();     // No usar esto, porque al dejar encendido el GARBAGE COL, Vuforia hace estragos: GCCollectDejandoEncendidoGCautomatico();    // Antes era: LIMPIAR Dejando encendido, porque quizá está en PAUSA; o lo requiere por haber entrado acá!

//                    // 2- Poner TIMER EN CERO otra vez. (En Ambos casos sirve: a- LIMPIADO: VOLVER A EMPEZAR .. b- NO LIMPIADO: Posponer).
//                    //
//                    this._miTiempoParaInvocarGCCollect = 0.0f;


//                }//End if (this._miMemoriaHeapGarbageActual < _TAMANO_HEAP_GARBAGE_MAXIMO_EMERGENCIA_BYTES)
//                else
//                {

//                    // Caso MEDIO - URGENTE, aguantable aún..
//                    //
//                    /////Debug.LogWarning("GAMEMANAGER GC : EVALUANDO MOMENTOS : Caso MEDIO - URGENTE, aguantable aún..");
//                    //
//                    // Heap no CRITICO:   NO LIMPIAR aun, POSPONER unos segundos (dado: _CONSTANTE_TIEMPO_MINIMA_N_SEGUNDOS_POSPONER_UN_POCO_INVOCACION_A_GC_COLLECT), 
//                    //...de esta manera no entrará dentro del IF PRINCIPAL del ALGORITMO, por unos pocos Segundos:
//                    //
//                    this._miTiempoParaInvocarGCCollect = _CONSTANTE_TIEMPO_MINIMA_N_SEGUNDOS_POSPONER_UN_POCO_INVOCACION_A_GC_COLLECT;

//                }//End else if (this._miMemoriaHeapGarbageActual < ..

//            }//End if (GC.GetTotalMemory(false) /* miGarbageActual */ > _TAMANO_HEAP_GARBAGE_MAXIMO_EMERGENCIA_BYTES)

//        }//End if (this._estaActivadoLimpiezaCadaNSegundosManual && ( this._miTiempoParaInvocarGCCollect > _CONSTANTE_TIEMPO_N_SEGUNDOS_INVOCAR_GC_COLLECT ))


//        #endregion Update  Garbage Collection

//        #region VIEJA : Update  Garbage Collection

//        //       // Mi GARBAGE COLLECTOR.
//        //       //
//        //       // Conteo del Tiempo ++ seg, DEL timer PARA LIMPIAR GC.COLLECT():
//        //       //
//        //       this._miTiempoParaInvocarGCCollect += Time.deltaTime;
//        //       //
//        //       // CADA 3 minutos : Limpiar la GARBAGE. //No esto (demasiadas preguntas, no): verificar si la MEMORIA del Heap (basura) es mayor a 36 MB.
//        //       //
//        //       if ( this._puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance  &&  ((this._miTiempoParaInvocarGCCollect > _CONSTANTE_TIEMPO_N_SEGUNDOS_INVOCAR_GC_COLLECT) || (GC.GetTotalMemory(false) > _TAMANO_HEAP_GARBAGE_MAXIMO_EMERGENCIA_BYTES) ) /*  &&  this._estaActivadoLimpiezaCadaNSegundosManual */)
//        //       {

//        //           // Eliminar estas 2 líneas de abajo:
//        //           //
//        //           //long miGarbageActual = GC.GetTotalMemory(false);
//        //           //Debug.LogWarning("GC : Memory used before collection (miGarbageActual KB): " + miGarbageActual);

//        //           if ( ( ((_mainGameState == _GAME_STATES.Playing) && ((this._gameStateWhenPlaying ==
//        //_GAME_STATES_WHEN_PLAYING.InicializacionFinalVariables) || (this._gameStateWhenPlaying ==
//        //_GAME_STATES_WHEN_PLAYING.PreparandoVariablesParaChutar))) || (_mainGameState == _GAME_STATES.GameOver) )  /* &&  (GC.GetTotalMemory(false) > _TAMANO_HEAP_GARBAGE_MAXIMO_EMERGENCIA_BYTES) */ )
//        //            //
//        //            //GC.GetTotalMemory(false) /* miGarbageActual */ > _TAMANO_HEAP_GARBAGE_MAXIMO_EMERGENCIA_BYTES)
//        //            //
//        //           {

//        //               // 1-Limpiar Basura de RAM:
//        //               //
//        //               _miGarbageCollectionManager.GCCollectApagandoGCautomatico();

//        //               // 2- Poner TIMER EN CERO otra vez. (En Ambos casos sirve: a- LIMPIADO: VOLVER A EMPEZAR .. b- NO LIMPIADO: Posponer).
//        //               //
//        //               this._miTiempoParaInvocarGCCollect = 0.0f;


//        //           }//End if (GC.GetTotalMemory(false) > _TAMANO_HEAP_GARBAGE_MAXIMO_EMERGENCIA_BYTES)
//        //           else    // 2- No es SUFICIENTEMENTE GRANDE el HEAP para limpiarlo: Posponer N-Segundos la Limpieza: 
//        //                   // 1- O no está en una FASE DE BAJO IMPACTO PERFORMANCE...
//        //           {
//        //               //this._estaActivadoLimpiezaCadaNSegundosManual = false;


//        //               // 2- Posponer un POCO la LIMPIEZA:
//        //               //
//        //               this._miTiempoParaInvocarGCCollect = _CONSTANTE_TIEMPO_N_SEGUNDOS_INVOCAR_GC_COLLECT - _CONSTANTE_TIEMPO_MINIMA_N_SEGUNDOS_PUEDE_INVOCAR_GC_COLLECT;

//        //           }//End if (GC.GetTotalMemory(false) /* miGarbageActual */ > _TAMANO_HEAP_GARBAGE_MAXIMO_EMERGENCIA_BYTES)


//        //       }//End if (this._estaActivadoLimpiezaCadaNSegundosManual && ( this._miTiempoParaInvocarGCCollect > _CONSTANTE_TIEMPO_N_SEGUNDOS_INVOCAR_GC_COLLECT ))

//        #endregion VIEJA : Update  Garbage Collection


//        /////Profiler.EndSample();

//    }//End Metodo Update


//    #region Metodos que no son de Base de Unity

//    #region GUI

//    /// <summary>
//    /// (Versión más optimizada que su antecesor, v1) Metodo que anota en variable el numero de goles de P1 y los escribe en la GUI para que se vea gráficamente.
//    /// Trabaja cambian la propiedad ""<Image>.color"", en lugar de cambiar de ""<Image>.sprite"" (mejorando el performance de la uGUI, Canvas, etc en cuanto a CPU Y GPU).
//    /// </summary>
//    public void ActualizarGolDeEsteTurno_v3(int miNumeroDeTurnoChute, bool fueGolOno, bool cambiarDeChutadorConElTurnoUNO_DOS, bool cambiarDeRoundTanda, bool aplicarReglasGanarOperderJuego)
//    {

////        // QUITAR AL RESOLVER EL PROBLEMA DE ""GARBAGE COLLECTOR"" , al ejecutar los "ToString()":
////        //
////        //Debug.Log("Pasó por el Método: 'ActualizarGolDeEsteTurno_v3(...)'... y generó basura con un 'ToString()' \n->\n...Y PINTÓ (poco) el GLOBO DE GOL cambiando la GUI GRÁFICA: CAMBIADO SOLAMENTE EL ''COLOR'' del GameObject/Image (todos se BATCHEAN juntos)");


//        // 1- Turno / Round de Chutes:
//        //
//        // Verificar si esta es la TANDA DE CHUTES # 1, o dos, o tres? => Con el COCIENTE. 
//        // Usar el MOD para el Numero de Ronda/Turno:
//        //
//        int numeroRealDeTurnoEnBaseA5 = miNumeroDeTurnoChute % this._NUMERO_DE_TURNOS_POR_TANDA;

//        // Turno número:
//        //
//        if (numeroRealDeTurnoEnBaseA5 > 0)
//        {

//            // Calcular (el Turno en Base a 5: Será el RESIDUO de la DIVISIÓN: (Turno MOD 5)):
//            //
//            miNumeroDeTurnoChute = numeroRealDeTurnoEnBaseA5;

//        }//End if ( miNumeroDeTurnoChute % this._NUMERO_DE_TURNOS_POR_TANDA )
//        else // == 0
//        {

//            // Valor que debe ser calculado diferentemente: Es 5, Pero el MOD dió cero (0)
//            //
//            miNumeroDeTurnoChute = this._NUMERO_DE_TURNOS_POR_TANDA;

//        }//End else


//        // Segun el numero del Jugador Actual (P1 = 1, P2 = 2, etc)
//        //
//        if (this._miJugadorActualQueChuta == this._miJugadorUNO)
//        {
//            // P1:
//            // 2- Verificar si fue GOL o no
//            //
//            if (fueGolOno)
//            {
//                // GOL:
//                //
//                // Variable logica de GOLES de P1:
//                //
//                this._golesAnotadosP1++;
//                //
//                // GUI:
//                // Actualizar el Score de Goles de P1:
//                //
//                ///26/10/2018: Comentado para MEJORA: SIN GARBAGE:  this._miGUIScoreGolesAnotadosTextP1.text = this._golesAnotadosP1.ToString();
//                /////Profiler.BeginSample("miProfile CastIntToStringNoGarbage");
//                //
//                ///this._miGUIScoreGolesAnotadosTextP1.text = this._golesAnotadosP1.ToString();
//                //
//                this.CastIntToStringNoGarbage( this._golesAnotadosP1, this._miTextoGolesP1EnGuiScoreGolesAnotados );
//                //
//                /////Profiler.EndSample();


//                // GUI: Poner color Verde de GOL ANOTADO
//                //
//                // Cambiar la IMAGEN por GOOOOL
//                //
//                ////Codigo original que fallaba: this._p1GolesImagenesUI[ miNumeroDeTurnoChute - 1 ].GetComponent<Image>().sprite = this._miImagenGolAnotado.sprite;
//                /////2018/10/17: Código v2 que era poco eficiente, mejorado al cambiar la configuración de los CANVAS de la GUI:    this._p1GolesImagenesUI[miNumeroDeTurnoChute - 1].GetComponent<Image>().sprite = this._miImagenGolAnotado;  //&&
//                //
//                /// Codigo original: this._p1GolesImagenesUI[miNumeroDeTurnoChute - 1].sprite = this._miImagenGolAnotado;
//                //
//                // Asignar un "color" o ""Tint"" (tintura) encima del Sprite original, color VERDE:
//                //
//                this._p1GolesImagenesUI[miNumeroDeTurnoChute - 1].color = _MI_COLOR_SEMAFORO_ROUND_GOL_ANOTADO; //Color.green;
//            }
//            else
//            {
//                // NO fue GOL.
//                // GUI: Poner color ROJO de GOL NO LOGRADO.
//                //
//                // Cambiar la IMAGEN por ""NO GOOOOL""
//                //
//                ////Codigo original que fallaba: this._p1GolesImagenesUI[ miNumeroDeTurnoChute - 1 ].GetComponent<Image>().sprite = this._miImagenGolFallado.sprite;
//                /////2018/10/17: Código v2 que era poco eficiente, mejorado al cambiar la configuración de los CANVAS de la GUI:    this._p1GolesImagenesUI[miNumeroDeTurnoChute - 1].GetComponent<Image>().sprite = this._miImagenGolFallado;  //&&
//                //
//                // CODIGO ORIGINAL: this._p1GolesImagenesUI[miNumeroDeTurnoChute - 1].sprite = this._miImagenGolFallado;
//                //
//                // Asignar un "color" o ""Tint"" (tintura) encima del Sprite original, color ROJO:
//                //
//                this._p1GolesImagenesUI[miNumeroDeTurnoChute - 1].color = _MI_COLOR_SEMAFORO_ROUND_GOL_FALLADO; //Color.red;

//            }//end else

//            // Pasamos a NUEVO Turno (siguiente).
//            //
//            this._numeroOrdinalDeTurnoJugadorUNO++;

//        }//end if (this._miJugadorActualQueChuta == this._miJugadorUNO)
//        //
//        else
//        {       
//            // P2 (CPU)
//            // 2- Verificar si fue GOL o no
//            //
//            if (fueGolOno)
//            {
//                // GOL:
//                //
//                // Variable logica de GOLES de P2:
//                //
//                this._golesAnotadosP2++;
//                //
//                // GUI:
//                // Actualizar el Score de Goles de P2:
//                //
//                ///26/10/2018: Comentado para MEJORA: SIN GARBAGE:  this._miGUIScoreGolesAnotadosTextP2.text = this._golesAnotadosP2.ToString();
//                //
//                /////Profiler.BeginSample("miProfile CastIntToStringNoGarbage");
//                //
//                this.CastIntToStringNoGarbage( this._golesAnotadosP2, this._miTextoGolesP2EnGuiScoreGolesAnotados );
//                ///this._miGUIScoreGolesAnotadosTextP2.text = this._golesAnotadosP2.ToString();
//                //
//                /////Profiler.EndSample();


//                // GUI: Poner color Verde de GOL ANOTADO
//                //
//                // Cambiar la IMAGEN por GOOOOL
//                //
//                ////Codigo original que fallaba: this._p2GolesImagenesUI[ miNumeroDeTurnoChute - 1 ].GetComponent<Image>().sprite = this._miImagenGolAnotado.sprite;
//                /////2018/10/17: Código v2 que era poco eficiente, mejorado al cambiar la configuración de los CANVAS de la GUI:    this._p2GolesImagenesUI[miNumeroDeTurnoChute - 1]./*GetComponent<Image>().*/sprite = this._miImagenGolAnotado;      //&&
//                //
//                // CODIGO ORIGINAL: this._p2GolesImagenesUI[miNumeroDeTurnoChute - 1].sprite = this._miImagenGolAnotado;
//                //
//                // Asignar un "color" o ""Tint"" (tintura) encima del Sprite original, color VERDE:
//                //
//                this._p2GolesImagenesUI[miNumeroDeTurnoChute - 1].color = _MI_COLOR_SEMAFORO_ROUND_GOL_ANOTADO; //Color.green;
//            }
//            else
//            {
//                // NO fue GOL.
//                // GUI: Poner color ROJO de GOL NO LOGRADO.
//                //
//                // Cambiar la IMAGEN por ""NO GOOOOL""
//                //
//                ////Codigo original que fallaba: this._p2GolesImagenesUI[ miNumeroDeTurnoChute - 1 ].GetComponent<Image>().sprite = this._miImagenGolFallado.sprite;
//                /////2018/10/17: Código v2 que era poco eficiente, mejorado al cambiar la configuración de los CANVAS de la GUI:    this._p2GolesImagenesUI[miNumeroDeTurnoChute - 1]./*GetComponent<Image>().*/sprite = this._miImagenGolFallado;      //&&
//                //
//                // CODIGO ORIGINAL: this._p2GolesImagenesUI[miNumeroDeTurnoChute - 1].sprite = this._miImagenGolFallado;
//                //
//                // Asignar un "color" o ""Tint"" (tintura) encima del Sprite original, color ROJO:
//                //
//                this._p2GolesImagenesUI[miNumeroDeTurnoChute - 1].color = _MI_COLOR_SEMAFORO_ROUND_GOL_FALLADO; //Color.red;

//            }//end else

//            // Pasamos a NUEVO Turno (siguiente).
//            //
//            this._numeroOrdinalDeTurnoJugadorCPU++;

//        }//end else del if (this._miJugadorActualQueChuta == this._miJugadorUNO)


//        // Aplicar Reglas de: GANAR o PERDER, el juego (según los GOLES anotados):
//        //
//        if (aplicarReglasGanarOperderJuego)
//        {

//            // Poner acá el Algoritmo de "verificar QUIÉN GANA el juego".
//            //
//            this.ChequearQuienGanaElJuego();
            
//        }//End if (aplicarReglasGanarOperderJuego)

//        // Cambiar de Turno:
//        //
//        if (cambiarDeChutadorConElTurnoUNO_DOS)
//        {

//            // Swap de valores dentro de variable de chutador actual:
//            //
//            _JUGADORES miChutadorAnterior = this._miJugadorActualQueChuta;
//            //
//            // Swap:
//            //
//            this._miJugadorActualQueChuta = this._miJugadorActualQuePortea;
//            this._miJugadorActualQuePortea = miChutadorAnterior;

//        }//End if (cambiarDeChutadorConElTurnoUNO_DOS)

//        // Cambiar de ROUND / TANDA:
//        //
//        if (cambiarDeRoundTanda)
//        {

//            // Refrescar GUI de Round actual
//            //
//            this.RefrescarGUIDeRoundIndividualSiAplica();

//            // Este refresca cada GRUPO DE 5: this.CambiarDe5RoundsSiAplica();

//        }//End if (cambiarDeRoundTanda)

//    }//End Metodo

////  Comentado porque se usará una versión OPTIMIZADA. v3 en adelante.
////	/// <summary>
////	/// Metodo que anota en variable el numero de goles de P1 y los escribe en la GUI para que se vea gráficamente.
////	/// </summary>
////    public void ActualizarGolDeEsteTurno(int miNumeroDeTurnoChute, bool fueGolOno, bool cambiarDeChutadorConElTurnoUNO_DOS, bool cambiarDeRoundTanda, bool aplicarReglasGanarOperderJuego)
////    {
////
////        // 1- Turno / Round de Chutes:
////        //
////        // Verificar si esta es la TANDA DE CHUTES # 1, o dos, o tres? => Con el COCIENTE. 
////        // Usar el MOD para el Numero de Ronda/Turno:
////        //
////        int numeroRealDeTurnoEnBaseA5 = miNumeroDeTurnoChute % this._NUMERO_DE_TURNOS_POR_TANDA;
////
////        // Turno número:
////        //
////        if (numeroRealDeTurnoEnBaseA5 > 0)
////        {
////
////            // Calcular (el Turno en Base a 5: Será el RESIDUO de la DIVISIÓN: (Turno MOD 5)):
////            //
////            miNumeroDeTurnoChute = numeroRealDeTurnoEnBaseA5;
////
////        }//End if ( miNumeroDeTurnoChute % this._NUMERO_DE_TURNOS_POR_TANDA )
////        else // == 0
////        {
////
////            // Valor que debe ser calculado diferentemente: Es 5, Pero el MOD dió cero (0)
////            //
////            miNumeroDeTurnoChute = this._NUMERO_DE_TURNOS_POR_TANDA;
////
////        }//End else
////
////
////        // Segun el numero del Jugador Actual (P1 = 1, P2 = 2, etc)
////        //
////        if (this._miJugadorActualQueChuta == this._miJugadorUNO)
////        {
////
////            // P1:
////            // 2- Verificar si fue GOL o no
////            //
////            if (fueGolOno)
////            {
////                // GOL:
////                //
////                // Variable logica de GOLES de P1:
////                //
////                this._golesAnotadosP1++;
////                //
////                // GUI:
////                // Actualizar el Score de Goles de P1:
////                //
////                this._miGUIScoreGolesAnotadosTextP1.text = this._golesAnotadosP1.ToString();
////
////                // GUI: Poner color Verde de GOL ANOTADO
////                //
////                // Cambiar la IMAGEN por GOOOOL
////                //
////                ////Codigo original que fallaba: this._p1GolesImagenesUI[ miNumeroDeTurnoChute - 1 ].GetComponent<Image>().sprite = this._miImagenGolAnotado.sprite;
////                /////2018/10/17: Código v2 que era poco eficiente, mejorado al cambiar la configuración de los CANVAS de la GUI:    this._p1GolesImagenesUI[miNumeroDeTurnoChute - 1].GetComponent<Image>().sprite = this._miImagenGolAnotado;  //&&
////                //
////                this._p1GolesImagenesUI[miNumeroDeTurnoChute - 1].sprite = this._miImagenGolAnotado;
////            }
////            else
////            {
////                // NO fue GOL.
////                // GUI: Poner color ROJO de GOL NO LOGRADO.
////                //
////                // Cambiar la IMAGEN por ""NO GOOOOL""
////                //
////                ////Codigo original que fallaba: this._p1GolesImagenesUI[ miNumeroDeTurnoChute - 1 ].GetComponent<Image>().sprite = this._miImagenGolFallado.sprite;
////                /////2018/10/17: Código v2 que era poco eficiente, mejorado al cambiar la configuración de los CANVAS de la GUI:    this._p1GolesImagenesUI[miNumeroDeTurnoChute - 1].GetComponent<Image>().sprite = this._miImagenGolFallado;  //&&
////                //
////                this._p1GolesImagenesUI[miNumeroDeTurnoChute - 1].sprite = this._miImagenGolFallado;
////
////            }//end else
////
////            // Pasamos a NUEVO Turno (siguiente).
////            //
////            this._numeroOrdinalDeTurnoJugadorUNO++;
////
////        }//end if (this._miJugadorActualQueChuta == this._miJugadorUNO)
////        //
////        else
////        {
////            // P2 (CPU)
////            // 2- Verificar si fue GOL o no
////            //
////            if (fueGolOno)
////            {
////                // GOL:
////                //
////                // Variable logica de GOLES de P2:
////                //
////                this._golesAnotadosP2++;
////                //
////                // GUI:
////                // Actualizar el Score de Goles de P2:
////                //
////                this._miGUIScoreGolesAnotadosTextP2.text = this._golesAnotadosP2.ToString();
////
////                // GUI: Poner color Verde de GOL ANOTADO
////                //
////                // Cambiar la IMAGEN por GOOOOL
////                //
////                ////Codigo original que fallaba: this._p2GolesImagenesUI[ miNumeroDeTurnoChute - 1 ].GetComponent<Image>().sprite = this._miImagenGolAnotado.sprite;
////                /////2018/10/17: Código v2 que era poco eficiente, mejorado al cambiar la configuración de los CANVAS de la GUI:    this._p2GolesImagenesUI[miNumeroDeTurnoChute - 1]./*GetComponent<Image>().*/sprite = this._miImagenGolAnotado;      //&&
////                //
////                this._p2GolesImagenesUI[miNumeroDeTurnoChute - 1].sprite = this._miImagenGolAnotado;
////            }
////            else
////            {
////                // NO fue GOL.
////                // GUI: Poner color ROJO de GOL NO LOGRADO.
////                //
////                // Cambiar la IMAGEN por ""NO GOOOOL""
////                //
////                ////Codigo original que fallaba: this._p2GolesImagenesUI[ miNumeroDeTurnoChute - 1 ].GetComponent<Image>().sprite = this._miImagenGolFallado.sprite;
////                /////2018/10/17: Código v2 que era poco eficiente, mejorado al cambiar la configuración de los CANVAS de la GUI:    this._p2GolesImagenesUI[miNumeroDeTurnoChute - 1]./*GetComponent<Image>().*/sprite = this._miImagenGolFallado;      //&&
////                //
////                this._p2GolesImagenesUI[miNumeroDeTurnoChute - 1].sprite = this._miImagenGolFallado;
////
////            }//end else
////
////            // Pasamos a NUEVO Turno (siguiente).
////            //
////            this._numeroOrdinalDeTurnoJugadorCPU++;
////
////        }//end else del if (this._miJugadorActualQueChuta == this._miJugadorUNO)
////
////
////        // Aplicar Reglas de: GANAR o PERDER, el juego (según los GOLES anotados):
////        //
////        if (aplicarReglasGanarOperderJuego)
////        {
////
////            // Poner acá el Algoritmo de "verificar QUIÉN GANA el juego".
////            //
////            this.ChequearQuienGanaElJuego();
////            
////        }//End if (aplicarReglasGanarOperderJuego)
////
////        // Cambiar de Turno:
////        //
////        if (cambiarDeChutadorConElTurnoUNO_DOS)
////        {
////
////            // Swap de valores dentro de variable de chutador actual:
////            //
////            _JUGADORES miChutadorAnterior = this._miJugadorActualQueChuta;
////            //
////            // Swap:
////            //
////            this._miJugadorActualQueChuta = this._miJugadorActualQuePortea;
////            this._miJugadorActualQuePortea = miChutadorAnterior;
////
////        }//End if (cambiarDeChutadorConElTurnoUNO_DOS)
////
////        // Cambiar de ROUND / TANDA:
////        //
////        if (cambiarDeRoundTanda)
////        {
////
////            // Refrescar GUI de Round actual
////            //
////            this.RefrescarGUIDeRoundIndividualSiAplica();
////
////            // Este refresca cada GRUPO DE 5: this.CambiarDe5RoundsSiAplica();
////
////        }//End if (cambiarDeRoundTanda)
////
////	}//End Metodo

    
//    /// <summary>
//    /// <para>Ganar the puntos de oro y experiencia, al meter un GOL o lograr algo dentro del juego.</para>
//    /// <para>NOTA: No se mostrara en ningún GameObject asociado a la GUI, eso deberá hacerse afuera de este Método</para>
//    /// </summary>
//    /// <param name="puntosOro">Puntos oro.</param>
//    /// <param name="puntosXP">Puntos X.</param>
//    public void GanarPuntosOroYExperienciaSinMostrarEnGUI(int puntosOro, int puntosXP)
//    {
//        // Ganar +puntos ORO
//        //
//        this._scorePuntosOroP1 += puntosOro;

//        // Ganar +Puntos EXPERIENCIA (XP):
//        //
//        this._scorePuntosXpP1 += puntosXP;


//        // Quitado porque nno corresponde a éste Método.
//        //
////        // Actualizar la GUI:
////        //
////        this._miPuntosOroGUI.text = this._scorePuntosOroP1.ToString();
////        this._miPuntosXPGUI.text = this._scorePuntosXPP1.ToString();

//        //Debug, quitar:
//        //
//        ////////Debug.Log("this._scorePuntosOroP1 = " + this._scorePuntosOroP1);
//        ////////Debug.Log("this._scorePuntosXPP1 = " + this._scorePuntosXPP1);
//    }


////	/// <summary>
////	/// Ganar the puntos de oro y experiencia, al meter un GOL o lograr algo dentro del juego.
////	/// </summary>
////	/// <param name="puntosOro">Puntos oro.</param>
////	/// <param name="puntosXP">Puntos X.</param>
////	public void GanarPuntosOroYExperiencia(int puntosOro, int puntosXP)
////	{
////		// Ganar +puntos ORO
////		//
////		this._scorePuntosOroP1 += puntosOro;
////
////		// Ganar +Puntos EXPERIENCIA (XP):
////		//
////		this._scorePuntosXPP1 += puntosXP;
////
////
////		// Actualizar la GUI:
////		//
////		this._miPuntosOroGUI.text = this._scorePuntosOroP1.ToString();
////		this._miPuntosXPGUI.text = this._scorePuntosXPP1.ToString();
////
////		//Debug, quitar:
////		//
////		////////Debug.Log("this._scorePuntosOroP1 = " + this._scorePuntosOroP1);
////		////////Debug.Log("this._scorePuntosXPP1 = " + this._scorePuntosXPP1);
////	}


//	/// <summary>
//	/// Updatea la sensibilidad del reconocedor de sonidos, usando la GUI (un SLIDER).
//	/// </summary>
//	public void UpdatearValorMicrofonoSensibilidadReconocedorDeSonidos()
//	{
//		// Nuevo valor?:
//		//
////        if (this._miMicrophoneInputDelBalon.sensitivity.CompareTo( this._miSliderReconocimientoDeSonidos.value ) != 0)
////        {
//            // Nuevo valor?:
//            //
//            this._miMicrophoneInputDelBalon.sensitivity = this._miSliderReconocimientoDeSonidos.value;

//            // Actualizar el MASTER VOLUME de la App: Validando que no pueda dispararse le Balón por accidente por el ruido de los Sonidos de la App 
//            // ..(moderando el 'Volumen Maestro' según la Sensibilidad del MICRÓFONO)
//            //
//        this.ActualizarVolumenSilbatosYBullaGeneralPublico();

////
////        }//End if
////
//	}//End Method


//	/// <summary>
//	/// Updatea la sensibilidad del SLIDER (GUI) del reconocedor de sonidos.
//	/// </summary>
//	/// <returns><c>true</c>, if sensibilidad reconocedor de sonidos was updated, <c>false</c> otherwise.</returns>
//	/// <param name="nuevoValorSensibilidad">Nuevo valor sensibilidad.</param>
//	public bool UpdatearGUISensibilidadReconocedorDeSonidos(float nuevoValorSensibilidad)
//	{
    
//		if ( this._miSliderReconocimientoDeSonidos != null )
//		{

//			// Nuevo valor:
//			//
//			this._miSliderReconocimientoDeSonidos.value = (int) nuevoValorSensibilidad;

//			return true;
//		}//end if

//		// No existe el objeto SLIDER UI, para usarlo.
//		//
//		return false;

//	}//End Method


//    #region Volumen de fondo debe bajar (Reconocedor de Sonidos) debido al Slider de Sensitivity de GUI

//    /// <summary>
//    /// Setea el VOLUMEN MAESTRO de todo el juego (i.e.: de las Cornetas, e.g.: musica y sonidos).
//    /// </summary>
//    private void SetMasterVolume( float nuevoMasterVolume )
//    {

//        // Cambia el Volumen Maestro de la App
//        // (NOTA: verificar que esto no cambie el volumen del Micrófono RECONOCEDOR DE SONIDOS).
//        //
//        AudioListener.volume = nuevoMasterVolume;

//    }//End Method

////    /// <summary>
////    /// Setea el VOLUMEN del SILBATAZO del árbitro + BULLA DE PÚBLICO (i.e.: de las Cornetas).
////    /// </summary>
////    private void SetVolumenSilbatoYPublico( float nuevoVolumen )
////    {
////        // Poner Volumen (nuevo) de: Silbatazo
////        //
////        this._miAudioSourceSilbatazos.volume = nuevoVolumen;
////
////        // Poner Volumen (nuevo) de: Bulla Público
////        //
////        this._miAudioSourceBullaGritosHumanosNormalConstante.volume = nuevoVolumen;
////
////    }//End Method


//    /// <summary>
//    /// Actualizar el Volumen de sonidos de acuerdo a la Sensibilidad del Microfono.
//    /// </summary>
//    public void ActualizarVolumenSilbatosYBullaGeneralPublico()
//    {
//        // 1- SILBATAZOS:
//        //
//        this._miAudioSourceSilbatazos.volume = this.ActualizarNuevoVolumenBasadoEnCalculoConNuevaSensibilidad( this._miSliderReconocimientoDeSonidos.value, this._miPendienteM_SensibilidadMicVsVolumenSilbatos, this._miOrdenadaEnOrigenB_SensibilidadMicVsVolumenSilbatos, this._volumenMinimoSilbatos, this._volumenMaximoSilbatos );

//        // 2- BULLA DE PÚBLICO:
//        //
//        this._miAudioSourceBullaGritosHumanosNormalConstante.volume = this.ActualizarNuevoVolumenBasadoEnCalculoConNuevaSensibilidad( this._miSliderReconocimientoDeSonidos.value, this._miPendienteM_SensibilidadMicVsVolumenBullaPublicoFondo, this._miOrdenadaEnOrigenB_SensibilidadMicVsVolumenBullaPublicoFondo, this._volumenMinimoBullaFondoPublico, this._volumenMaximoBullaFondoPublico );

//    }//End Method


//    /// <summary>
//    /// Calcula el nuevo MASTER VOLUME basado en la VARIACION de Sensibilidad del "Reconocedor de Sonidos" (i.e.: Micrófono).
//    /// </summary>
//    private void ActualizarNuevoVolumenMaestroBasadoEnCalculoConNuevaSensibilidad(float volumenSensibilidadNuevo)
//    {
//        // Determinar el NUEVO VOLUMEN MAESTRO (basado en el Valor de SENSIBILIDAD del Micrófono):
//        //
//        float nuevoVolumenMaestro = (this._miPendienteM_SensibilidadMicVsVolumenSilbatos * (volumenSensibilidadNuevo /* this._miSliderReconocimientoDeSonidos.value */)) + (this._miOrdenadaEnOrigenB_SensibilidadMicVsVolumenSilbatos);

//        // Validación del nuevo MASTER VOLUME:
//        //
//        if (nuevoVolumenMaestro > 1.0f)
//        {

//            nuevoVolumenMaestro = 1.0f;

//        }//End if (nuevoVolumenMaestro > 1.0f)
//        else if ( nuevoVolumenMaestro < 0.1f )
//        {

//            nuevoVolumenMaestro = 0.1f;     //Mínimo.

//        }//End else del if (nuevoVolumenMaestro > 1.0f)

//        // Correcto (validado)
//        // Actualizar realmente el VOLUMEN MAESTRO:
//        //
//        this.SetMasterVolume( nuevoVolumenMaestro );
    
//    }//End Method


//    /// <summary>
//    /// Calcula el nuevo VOLUMEN de SILBATOS y BULLA FONDO DEL PUBLICO, basado en la VARIACION de Sensibilidad del "Reconocedor de Sonidos" (i.e.: Micrófono).
//    /// </summary>
//    private float ActualizarNuevoVolumenBasadoEnCalculoConNuevaSensibilidad(float volumenSensibilidadNuevo, float pendienteM, float ordenadaEnElOrigen, float minVolumen, float maxVolumen)
//    {
//        // Determinar el NUEVO VOLUMEN (basado en el Valor de SENSIBILIDAD del Micrófono):
//        //
//        float nuevoVolumenMaestro = (pendienteM * (volumenSensibilidadNuevo)) + (ordenadaEnElOrigen);

//        // Validación del nuevo MASTER VOLUME:
//        //
//        if (nuevoVolumenMaestro > maxVolumen)
//        {

//            nuevoVolumenMaestro = maxVolumen;

//        }//End if (nuevoVolumenMaestro > 1.0f)
//        else if ( nuevoVolumenMaestro < minVolumen )
//        {

//            nuevoVolumenMaestro = minVolumen;     //Mínimo.

//        }//End else del if (nuevoVolumenMaestro > 1.0f)

//        // Correcto (validado)
//        // RETORNAR PARA PODER SETEAR EL VOLUMEN DEL ""AUDIOSOURCE"" AFUERA DEL MÉTODO:
//        //
//        return nuevoVolumenMaestro;
    
//    }//End Method


//    /// <summary>
//    /// Obtiene la pendiente (m) de una ECUACIÓN PUNTO-PENDIENTE de LÍNEA RECTA.
//    /// </summary>
//    public float CalculaYDevuelvePendienteMdeLineaRecta( float yFinal, float yInicial, float xFinal, float xInicial )
//    {
//        // Ecuación de LÍNEA RECTA:
//        // m = Pendiente: = (y2 - y1) / (x2 - x1)
//        //
//        return ((yFinal - yInicial) / (xFinal - xInicial));

//    }//End Method

//    /// <summary>
//    /// Obtiene la ORDENADA EN EL ORIGEN (i.e.: Valor de y=? cuando x=0): 'b' de una ECUACIÓN PUNTO-PENDIENTE de LÍNEA RECTA.
//    /// </summary>
//    public float CalculaYDevuelveOrdenadaEnOrigenBdeLineaRecta( float pendienteDeLineaRectaM, float xFinal )
//    {
//        // Ecuación de LÍNEA RECTA:
//        // b = - (m * xFinal)
//        //
//        return ((-1) * ( pendienteDeLineaRectaM * xFinal ));

//    }//End Method

//    #endregion Volumen de fondo debe bajar (Reconocedor de Sonidos) debido al Slider de Sensitivity de GUI


//    #region Barra de Globos de Colores de GOOOL

//    /// <summary>
//    /// (Más EFICIENTE que la versión v2) Limpia en color Gris (default) la GUI de GOLES ANOTADOS.
//    /// A diferencia de las versions anteriores, trabaja cambiando el COLOR del SPRITE ORIGINAL, no cambiando la imagen. Esto supone un ahorro de trabajo de CPU (y de GPU).
//    /// Esta versión es para ser usada con la nueva GUI (CANVAS DINÁMICOS Y ESTÁTICOS separados, para mejor performance).
//    /// </summary>
//    /// <returns><c>true</c>, if GUI de goles anotados was limpiared, <c>false</c> otherwise.</returns>
//    private void LimpiarGUIdeGolesAnotados_v3()
//    {
//        // Limpiar
//        //
//        if ( (this._numeroOrdinalDeTurnoJugadorUNO > this._NUMERO_DE_TURNOS_POR_TANDA) && (this._numeroOrdinalDeTurnoJugadorCPU > this._NUMERO_DE_TURNOS_POR_TANDA) && ( (this._numeroOrdinalDeTurnoJugadorUNO % this._NUMERO_DE_TURNOS_POR_TANDA) == 1 ) && ( (this._numeroOrdinalDeTurnoJugadorCPU % this._NUMERO_DE_TURNOS_POR_TANDA) == 1 ))
//        {

////            // QUITAR AL RESOLVER EL PROBLEMA DE ""GARBAGE COLLECTOR"" , al ejecutar los "ToString()":
////            //
////            //Debug.Log("Pasó por el Método: 'LimpiarGUIdeGolesAnotados_v3()'... y generó basura con un 'ToString()' \n...También PINTÓ TOOODA (mucho!) la GUI GRÁFICA DE GOLES: Cambiando el COLOR de cada IMAGE (globo) de GOL");

//            // Limpiar toda la GUI de Goles:
//            //
//            /////Este es el SLOT de GOL-GUI actual a Chutar: this._p1GolesImagenesUI[miNumeroDeTurnoChute - 1].GetComponent<Image>().sprite = this._miImagenChuteNoDisparadoAun;


//            // Recorrer con un For-Loop todas las imágenes:
//            //
//            for (int i = 0; i < this._p1GolesImagenesUI_Longitud; i++)
//            {

//                // numeroOrdinalDeTurno
//                //
//                int numeroOrdinalDeTurno = this._numeroOrdinalDeTurnoJugadorUNO + i;

//                /////////////////// P1
                               
//                // Limpiar en color Gris la GUI de Goles Anotados:
//                //
//                /////2018/10/17: Código v2 que era poco eficiente, mejorado al cambiar la configuración de los CANVAS de la GUI: this._p1GolesImagenesUI[ i ]./*GetComponent<Image>().*/sprite = this._miImagenChuteNoDisparadoAun;      //&&
//                //2018/10/24:   CÓDIGO v2 era aún deficiente porque cambiaba de SPRITE y no había un batching de ""todos los globos de gol"", sino en varios grupos (buu!): this._p1GolesImagenesUI[ i ].sprite = this._miImagenChuteNoDisparadoAun;
//                //
//                this._p1GolesImagenesUI[ i ].color = _MI_COLOR_SEMAFORO_ROUND_CHUTE_NO_DISPARADO_AUN;  //Color.gray;

//                // Cambiar y adecuar el NÚMERO ORDINAL DE GOL (c/u):
//                //
//                /////2018/10/17: Código v2 que era poco eficiente, mejorado al cambiar la configuración de los CANVAS de la GUI: this._p1GolesImagenesUI[ i ].GetComponentInChildren<Text>().text*/ = numeroOrdinalDeTurno.ToString();     //&&
//                //
//                ///26/10/2018: Comentado para MEJORA: SIN GARBAGE:  this._p1GolesTextoUI[ i ].text = numeroOrdinalDeTurno.ToString();
//                //
//                /////Profiler.BeginSample("miProfile CastIntToStringNoGarbage");
//                //
//                this.CastIntToStringNoGarbage( numeroOrdinalDeTurno, this._p1GolesTextoUI[ i ] );
//                ///this._p1GolesTextoUI[ i ].text = numeroOrdinalDeTurno.ToString();
//                //
//                /////Profiler.EndSample();


//                ////////////////// P2

//                // Limpiar en color Gris la GUI de Goles Anotados:
//                //
//                /////2018/10/17: Código v2 que era poco eficiente, mejorado al cambiar la configuración de los CANVAS de la GUI: this._p2GolesImagenesUI[ i ]./*GetComponent<Image>().*/sprite = this._miImagenChuteNoDisparadoAun;      //&&
//                //2018/10/24:   CÓDIGO v2 era aún deficiente porque cambiaba de SPRITE y no había un batching de ""todos los globos de gol"", sino en varios grupos (buu!): this._p2GolesImagenesUI[ i ].sprite = this._miImagenChuteNoDisparadoAun;
//                //
//                this._p2GolesImagenesUI[ i ].color =  _MI_COLOR_SEMAFORO_ROUND_CHUTE_NO_DISPARADO_AUN;  //Color.gray;


//                // Cambiar y adecuar el NÚMERO ORDINAL DE GOL (c/u):
//                //
//                /////2018/10/17: Código v2 que era poco eficiente, mejorado al cambiar la configuración de los CANVAS de la GUI: this._p2GolesImagenesUI[ i ].GetComponentInChildren<Text>().text = numeroOrdinalDeTurno.ToString();    //&&
//                //
//                ///26/10/2018: Comentado para MEJORA: SIN GARBAGE:  this._p2GolesTextoUI[ i ].text = numeroOrdinalDeTurno.ToString();
//                //
//                /////Profiler.BeginSample("miProfile CastIntToStringNoGarbage");
//                //
//                this.CastIntToStringNoGarbage( numeroOrdinalDeTurno, this._p2GolesTextoUI[ i ] );
//                ///this._p2GolesTextoUI[ i ].text = numeroOrdinalDeTurno.ToString();
//                //
//                /////Profiler.EndSample();

//            }//End for

//            // Optimización:    return true;

//        }//End if

//        // Optimización:    return false;

//    }//End Metodo


////  Comentado porque se usará una versión OPTIMIZADA. v3 en adelante.
////    /// <summary>
////    /// (Más EFICIENTE que la versión v1) Limpia en color Gris (default) la GUI de GOLES ANOTADOS.
////    /// Esta versión es para ser usada con la nueva GUI (CANVAS DINÁMICOS Y ESTÁTICOS separados, para mejor performance).
////    /// </summary>
////    /// <returns><c>true</c>, if GUI de goles anotados was limpiared, <c>false</c> otherwise.</returns>
////    private bool LimpiarGUIdeGolesAnotados_v2()
////    { 
////        // Limpiar
////        //
////        if ( (this._numeroOrdinalDeTurnoJugadorUNO > this._NUMERO_DE_TURNOS_POR_TANDA) && (this._numeroOrdinalDeTurnoJugadorCPU > this._NUMERO_DE_TURNOS_POR_TANDA) && ( (this._numeroOrdinalDeTurnoJugadorUNO % this._NUMERO_DE_TURNOS_POR_TANDA) == 1 ) && ( (this._numeroOrdinalDeTurnoJugadorCPU % this._NUMERO_DE_TURNOS_POR_TANDA) == 1 ))
////        {
////
////            // Limpiar toda la GUI de Goles:
////            //
////            /////Este es el SLOT de GOL-GUI actual a Chutar: this._p1GolesImagenesUI[miNumeroDeTurnoChute - 1].GetComponent<Image>().sprite = this._miImagenChuteNoDisparadoAun;
////
////            // P1
////            //
////            int golesImagenesUI_Length = this._p1GolesImagenesUI.Length;
////            //
////            for (int i = 0; i < golesImagenesUI_Length; i++)
////            {
////
////                // numeroOrdinalDeTurno
////                //
////                int numeroOrdinalDeTurno = this._numeroOrdinalDeTurnoJugadorUNO + i;
////
////                /////////////////// P1
////                               
////                // Limpiar en color Gris la GUI de Goles Anotados:
////                //
////                /////2018/10/17: Código v2 que era poco eficiente, mejorado al cambiar la configuración de los CANVAS de la GUI: this._p1GolesImagenesUI[ i ]./*GetComponent<Image>().*/sprite = this._miImagenChuteNoDisparadoAun;      //&&
////                //
////                this._p1GolesImagenesUI[ i ].sprite = this._miImagenChuteNoDisparadoAun;
////
////                // Cambiar y adecuar el NÚMERO ORDINAL DE GOL (c/u):
////                //
////                /////2018/10/17: Código v2 que era poco eficiente, mejorado al cambiar la configuración de los CANVAS de la GUI: this._p1GolesImagenesUI[ i ].GetComponentInChildren<Text>().text*/ = numeroOrdinalDeTurno.ToString();     //&&
////                //
////                this._p1GolesTextoUI[ i ].text = numeroOrdinalDeTurno.ToString();
////
////                ////////////////// P2
////
////                // Limpiar en color Gris la GUI de Goles Anotados:
////                //
////                /////2018/10/17: Código v2 que era poco eficiente, mejorado al cambiar la configuración de los CANVAS de la GUI: this._p2GolesImagenesUI[ i ]./*GetComponent<Image>().*/sprite = this._miImagenChuteNoDisparadoAun;      //&&
////                //
////                this._p2GolesImagenesUI[ i ].sprite = this._miImagenChuteNoDisparadoAun;
////
////
////                // Cambiar y adecuar el NÚMERO ORDINAL DE GOL (c/u):
////                //
////                /////2018/10/17: Código v2 que era poco eficiente, mejorado al cambiar la configuración de los CANVAS de la GUI: this._p2GolesImagenesUI[ i ].GetComponentInChildren<Text>().text = numeroOrdinalDeTurno.ToString();    //&&
////                //
////                this._p2GolesTextoUI[ i ].text = numeroOrdinalDeTurno.ToString();
////
////            }//End for
////
////            return true;
////
////        }//End if
////
////        return false;
////
////    }//End Metodo


////  Comentado porque se usará una versión OPTIMIZADA. v3 en adelante.
////    /// <summary>
////    /// (Deprecated, no es eficiente, no "performant") Limpia en color Gris (default) la GUI de GOLES ANOTADOS.
////    /// </summary>
////    /// <returns><c>true</c>, if GUI de goles anotados was limpiared, <c>false</c> otherwise.</returns>
////    private bool LimpiarGUIdeGolesAnotados_v1()
////    {
////
////        // Limpiar
////        //
////        if ( (this._numeroOrdinalDeTurnoJugadorUNO > this._NUMERO_DE_TURNOS_POR_TANDA) && (this._numeroOrdinalDeTurnoJugadorCPU > this._NUMERO_DE_TURNOS_POR_TANDA) && ( (this._numeroOrdinalDeTurnoJugadorUNO % this._NUMERO_DE_TURNOS_POR_TANDA) == 1 ) && ( (this._numeroOrdinalDeTurnoJugadorCPU % this._NUMERO_DE_TURNOS_POR_TANDA) == 1 ))
////        {
////
////            // Limpiar toda la GUI de Goles:
////            //
////            /////Este es el SLOT de GOL-GUI actual a Chutar: this._p1GolesImagenesUI[miNumeroDeTurnoChute - 1].GetComponent<Image>().sprite = this._miImagenChuteNoDisparadoAun;
////
////            // P1
////            //
////            int golesImagenesUI_Length = this._p1GolesImagenesUI.Length;
////            //
////            for (int i = 0; i < golesImagenesUI_Length; i++)
////            {
////
////                // numeroOrdinalDeTurno
////                //
////                int numeroOrdinalDeTurno = this._numeroOrdinalDeTurnoJugadorUNO + i;
////
////                /////////////////// P1
////
////                // Limpiar en color Gris la GUI de Goles Anotados:
////                //
////                this._p1GolesImagenesUI[ i ]./*GetComponent<Image>().*/sprite = this._miImagenChuteNoDisparadoAun;      //&&
////
////
////                // Cambiar y adecuar el NÚMERO ORDINAL DE GOL (c/u):
////                //
////                /////this._p1GolesImagenesUI[ i ].GetComponentInChildren<Text>().text = numeroOrdinalDeTurno.ToString();    //&&
////
////                ////////////////// P2
////
////                // Limpiar en color Gris la GUI de Goles Anotados:
////                //
////                this._p2GolesImagenesUI[ i ]./*GetComponent<Image>().*/sprite = this._miImagenChuteNoDisparadoAun;      //&&
////
////
////                // Cambiar y adecuar el NÚMERO ORDINAL DE GOL (c/u):
////                //
////                /////this._p2GolesImagenesUI[ i ].GetComponentInChildren<Text>().text = numeroOrdinalDeTurno.ToString();    //&&
////
////            }//End for
////
////            return true;
////
////        }//End if
////
////        return false;
////
////    }//End Metodo

//    #endregion Barra de Globos de Colores de GOOOL


//    /// <summary>
//    /// Cambiar de Round (las variables) si aplica.
//    /// Un ROUND / TANDA es un Turno de 1 GOL hecho por ambos Equipos.
//    /// </summary>
//    /// <returns>El Round actual</returns>
//    private void RefrescarGUIDeRoundIndividualSiAplica()
//    {

//        // Verificar si se cambió de Round / Tanda de Goles: El residuo de la Division debe dar UNO.
//        //
//        if ( (this._numeroOrdinalDeTurnoJugadorUNO > this._numeroOrdinalDeTurnoJugadorCPU) || (this._miJugadorActualQueChuta == this._miJugadorUNO) )
//        {
////            // QUITAR AL RESOLVER EL PROBLEMA DE ""GARBAGE COLLECTOR"" , al ejecutar los "ToString()":
////            //
////            //Debug.Log("Pasó por el Método: 'LimpiarGUIdeGolesAnotados_v3()'... y generó basura con un 'ToString()' \nPero SOLAMENTE PINTÓ (poco) un UI TEXT cambiado");


//            // GUI: actualizar el numero del Round allí:
//            //
//            ///26/10/2018: Comentado para MEJORA: SIN GARBAGE:  this._miRoundTandaGUIText_Numero.text = this._numeroOrdinalDeTurnoJugadorCPU.ToString();
//            //
//            /////Profiler.BeginSample("miProfile CastIntToStringNoGarbage");
//            //
//            this.CastIntToStringNoGarbage( this._numeroOrdinalDeTurnoJugadorCPU, this._miRoundTandaGUIText_Numero );
//            //
//            ///this._miRoundTandaGUIText_Numero.text = this._numeroOrdinalDeTurnoJugadorCPU.ToString();
//            //
//            /////Profiler.EndSample();

//        }//End if

////        // Retornar la variable: Número de ROUND / TANDA:
////        //
////        return this._numeroOrdinalDeTurnoJugadorCPU;
//    }//End Metodo



//    /// <summary>
//    /// Cambiar de Round (las variables) si aplica.
//    /// 5 ROUNDs / TANDAs son un grupo de 5 Goles (1,2,3,4,5 ; 6,7,8,9,10 ; 11,12,13,14,15 ; etc).
//    /// </summary>
//    /// <returns>El Round actual</returns>
//    private int CambiarDe5RoundsSiAplica()
//    {

//        // Verificar si se cambió de Round / Tanda de Goles: El residuo de la Division debe dar UNO.
//        //
//        if (( (this._numeroOrdinalDeTurnoJugadorUNO % this._NUMERO_DE_TURNOS_POR_TANDA) == 1 ) && ( (this._numeroOrdinalDeTurnoJugadorCPU % this._NUMERO_DE_TURNOS_POR_TANDA) == 1 ))
//        {
//            // Si aplica, incrementar la Variable:
//            //
//            this._numeroOrdinalDe5Rounds++;

////            // GUI: actualizar el numero del Round allí:
////            //
////            this._miRoundTandaGUIText_Numero.text = this._numeroOrdinalDe5Rounds.ToString();

//        }//End if

//        // Retornar la variable: Número de 5 ROUNDs / TANDAs:
//        //
//        return this._numeroOrdinalDe5Rounds;

//    }//End Metodo


//    #region GUI de SCORE resultante GOLES, e.g.: (1 - 0)

////    /// <summary>
////    /// Activa o Desactiva la visibilidad del Componente Canvas de letras 'Score Resultante Goles'.
////    /// </summary>
////    public void ActivarDesactivarVisibilidadCanvasDeLetrasScoreResultanteGoles( bool activarOdesactivar )
////    {
//////        // Log de prueba:
//////        //
//////        //Debug.Log("Pasé por Método: 'ActivarDesactivarVisibilidadCanvasDeLetrasScoreResultanteGoles( bool activarOdesactivar = "+ activarOdesactivar +" )'");
////
////
////        // Activar o desactivar el COMPONENTE CANVAS, en lugar del GAMEOBJECT CANVAS, es más 'performant' (ÓPTIMO):
////        //
////        ///// Optimización: this._miScoreGolesAnotadosTextosComponenteCanvasEnGameObjectCanvas.enabled = activarOdesactivar;
////        //
////        if ( activarOdesactivar && ( this._miScoreGolesAnotadosTextosComponenteCanvasEnGameObjectCanvas.transform.lossyScale.x < 1.0f ) )
////        {
////
////            // OPTIMIZACIÓN: Poner al GameObject de tamano "normal" otra vez:
////            //
////            //this._miScriptTweensScoreAvsBv3.DO_Rewind_MyAnimations();
////            //
////            this._miScriptTweensScoreAvsBv3.DO_Stop_MyAnimations();
////            //
////            this._miScoreGolesAnotadosTextosComponenteCanvasEnGameObjectCanvas.transform.localScale.Set( 1.0f, 1.0f, 1.0f );
////
////        }//End if ( activarOdesactivar )
////        else
////        {
////
////            // OPTIMIZACIÓN: Poner al GameObject de tamano "pequenito" (para que no lo puedan ver):
////            //
////            //this._miScriptTweensScoreAvsBv3.DO_Rewind_MyAnimations();
////            //
////            this._miScriptTweensScoreAvsBv3.DO_Stop_MyAnimations();
////            //
////            this._miScoreGolesAnotadosTextosComponenteCanvasEnGameObjectCanvas.transform.localScale.Set( 0.0f, 0.0f, 0.0f );
////
////        }//End else
////
////
////        // Si vamos a esconder el CANVAS (es decir: se terminará la Animación), debemos SETEARLE SUS PARÁMETROS INICIALES NUEVAMENTE:
////        //..ESCALA = 1, POSICION = 0.0f, ROTACION = 0.0f, ETC..
//////        //
//////        if (!activarOdesactivar)
//////        {
//////            //this._miScriptTweensScoreAvsBv3.DO_Rewind_MyAnimations();
//////            //
//////            this._miScriptTweensScoreAvsBv3.DO_Stop_MyAnimations();
//////
//////        }//end if
////
////    }//End Method

//    /// <summary>
//    /// Activa una Animacion ALEATORIA de letras:  SCORE GOL (1 - 0)
//    /// </summary>
//    public void IniciarAnimacionAleatoriaDeLetrasScoreResultanteGoles()
//    {
////        // Log de prueba:
////        //
////        //Debug.Log("Pasé por Método: 'IniciarAnimacionAleatoriaDeLetrasScoreResultanteGoles()'");


//        // PLAY de la Animacion ALEATORIAMENTE:
//        //
//        this._miScriptTweensScoreAvsBv3.DO_PlayAnimacion();

//    }//End Method

//    /// <summary>
//    /// Termina (haciendo un REBOBINAR + PAUSA): una Animacion ALEATORIA de letras: SCORE GOL (1 - 0)
//    /// </summary>
//    public void TerminarAnimacionAleatoriaDeLetrasScoreResultanteGoles()
//    {
////        // Log de prueba:
////        //
////        //Debug.Log("Pasé por Método: 'TerminarAnimacionAleatoriaDeLetrasScoreResultanteGoles()'");

//        // Stop + RRewind + Pausa: de las Animaciones actuales, y el estado del(os) GameObject(s)
//        //
//        this._miScriptTweensScoreAvsBv3.DO_Rewind_MyAnimations();

//    }//End Method


//    #endregion GUI de SCORE resultante GOLES, e.g.: (1 - 0)


//    #region GUI DE ROUND X

//    /// <summary>
//    /// Activa o Desactiva la visibilidad del Componente Canvas de letras round x.
//    /// </summary>
//    public void ActivarDesactivarVisibilidadCanvasDeLetrasRoundX( bool activarOdesactivar )
//    {
////        // Log de prueba:
////        //
////        //Debug.Log("Pasé por Método: 'ActivarDesactivarVisibilidadCanvasDeLetrasRoundX( bool activarOdesactivar = "+ activarOdesactivar +" )'");


//        // Si vamos a esconder el CANVAS (es decir: se terminará la Animación), debemos SETEARLE SUS PARÁMETROS INICIALES NUEVAMENTE:
//        //..ESCALA = 1, POSICION = 0.0f, ROTACION = 0.0f, ETC..
//        //
//        if (! activarOdesactivar)    // False
//        {
//            // Está Activo? => Deshabilitar (Esconder)
//            //
//            if ( this._miRoundTandaGUIComponenteCanvasEnGameObjectCanvas.enabled /* this._miRoundTandaGUIComponenteCanvasEnGameObjectCanvas.isActiveAndEnabled */)
//            {
//                // Desactivar el COMPONENTE CANVAS, en lugar del GAMEOBJECT CANVAS, es más 'performant' (ÓPTIMO):
//                //
//                this._miRoundTandaGUIComponenteCanvasEnGameObjectCanvas.enabled = false;

//                //this._miScriptTweensRoundX.DO_Rewind_MyAnimations();
//                //
//                this._miScriptTweensRoundX.DO_Stop_MyAnimations();

//            }//End if

//        }//end if
//        else    // True
//        {
//            // Está NO-Activo? => Mostrar.
//            //
//            if (! this._miRoundTandaGUIComponenteCanvasEnGameObjectCanvas.enabled /* this._miRoundTandaGUIComponenteCanvasEnGameObjectCanvas.isActiveAndEnabled */)
//            {
//                // Activar el COMPONENTE CANVAS, en lugar del GAMEOBJECT CANVAS, es más 'performant' (ÓPTIMO):
//                //
//                this._miRoundTandaGUIComponenteCanvasEnGameObjectCanvas.enabled = true;

//            }//End if

//        }//End else

//    }//End Method


//    /// <summary>
//    /// Activa una Animacion ALEATORIA de letras ROUND X.
//    /// </summary>
//    public void ActivarAnimacionAleatoriaDeLetrasRoundX()
//    {
////        // Log de prueba:
////        //
////        //Debug.Log("Pasé por Método: 'ActivarAnimacionAleatoriaDeLetrasRoundX()'");


//        // PLAY de la Animacion ALEATORIAMENTE:
//        //
//        this._miScriptTweensRoundX.DO_PlayAnimacion();

//    }//End Method

//    #endregion GUI DE ROUND X   


//    #region GUI de SLIDER RECONOCIMIENTO DE VOZ

//    /// <summary>
//    /// Activar o Desactiva la Visibilidad del GUI Slider de Reconocimiento de Voz (Componente Canvas).
//    /// </summary>
//    public void ActivarDesactivarGUISliderReconocimientoDeVozComponenteCanvas( bool activarOdesactivar )
//    {
//        // Inicializar los COMPONENTES CANVAS del UI SLIDER DE RECONOCIMEINTO DE SONIDOS:
//        //
//        if ( ( this._misCanvasComponentUIDelSliderReconocimientoDeSonidos != null ) && ( this._misCanvasComponentUIDelSliderReconocimientoDeSonidos_Longitud > 0 ) /* &&  ( this._misCanvasComponentUIDelSliderReconocimientoDeSonidos[0] != null ) */ )
//        {
//            // BUSCAR (CANVAS COMPONENT que es un 'Component')
//            //
//            for (int i = 0; i < this._misCanvasComponentUIDelSliderReconocimientoDeSonidos_Longitud; i++)
//            {
//                // Extraer el 'Componente Canvas' y activarlo o desactivarlo, según sea el caso:
//                // Sólo cambiar si el ESATDO ES DIFERENTE:
//                //
//                if ( ( this._misCanvasComponentUIDelSliderReconocimientoDeSonidos[i] != null )  /* &&  (this._misCanvasComponentUIDelSliderReconocimientoDeSonidos[ i ].enabled != activarOdesactivar) */ )
//                {
//                    // Cambiar ESTADO:
//                    //
//                    /////this._misCanvasComponentUIDelSliderReconocimientoDeSonidos[ i ].enabled = activarOdesactivar;
//                    //
//                    Canvas miCanvas = this._misCanvasComponentUIDelSliderReconocimientoDeSonidos[i] as Canvas;  //.GetComponent<Canvas>();

//                    // Hay 3 tipos de Objectos posibles (e.g.: RectTransform, Rect y Canvas), los vamos a deshabilitar a todos:
//                    //
//                    if ( ( miCanvas != null ) && ( miCanvas.enabled != activarOdesactivar ) )
//                    {
//                        // CANVAS
//                        //
//                        miCanvas.enabled = activarOdesactivar;

//                    }
//                    else //if ( this._misCanvasComponentUIDelSliderReconocimientoDeSonidos[i].activeInHierarchy != activarOdesactivar )
//                    {
//                        // GAMEOBJECT en general: Tiene la propiedad .enable (GET, SET):
//                        //
//                        GameObject miGameObject = this._misCanvasComponentUIDelSliderReconocimientoDeSonidos[i] as GameObject;  //.SetActive( activarOdesactivar );
//                        //
//                        if ( (miGameObject != null) && (miGameObject.activeSelf != activarOdesactivar ) )    // Si tiene un ESTADO DISTINTO al solicitado.
//                        {

//                            // Cambiar estado al solicitado:
//                            //
//                            miGameObject.SetActive( activarOdesactivar );

//                        }//End if ( (miGameObject != null) && (miGameObject.activeSelf != activarOdesactivar ) )

//                    }//End else if ( this._misCanvasComponentUIDelSliderReconocimientoDeSonidos[i].activeInHierarchy != activarOdesactivar )

//                }//End if (this._misCanvasComponentUIDelSliderReconocimientoDeSonidos[ i ].enabled != activarOdesactivar)

//            }//End for

//        }//End if ( ( this._misCanvasComponentUIDelSliderReconocimientoDeSonidos != null ) && ( this._misCanvasComponentUIDelSliderReconocimientoDeSonidos[0] != null ) )

//    }//End Method

//    #endregion


//    #region GUI de MENU PAUSA / LET'S PLAY!

//    /// <summary>
//    /// Activar o Desactiva la Visibilidad del GUI Menu Pausa/Let's Play (Componente Canvas).
//    /// </summary>
//    public void ActivarDesactivarCanvasGUIMenuPausaLetsPlayComponenteCanvas(bool activarOdesactivar)
//    {
//        // 'Componente Canvas' y activarlo o desactivarlo, según sea el caso:
//        // Sólo cambiar si el ESTADO ES DIFERENTE:
//        //
//        if ((this._miMenuPauseGUIComponenteCanvasEnGameObjectCanvas != null) && (this._miMenuPauseGUIComponenteCanvasEnGameObjectCanvas.enabled != activarOdesactivar))
//        {
//            // CANVAS
//            //
//            this._miMenuPauseGUIComponenteCanvasEnGameObjectCanvas.enabled = activarOdesactivar;

//        }//End if

//    }//End Method


//    #endregion GUI de MENU PAUSA / LET'S PLAY!

//    #endregion GUI


//    #region Logica y Dinamica del Juego


//    /// <summary>
//    /// Chequea quien gana el juego.
//    /// PRERREQUISITO:  Que ya se haya anotado el GOL y se actualizó el #NÚMERO TURNO del Jugador que acaba de Chutar.
//    /// </summary>
//    private void ChequearQuienGanaElJuego()
//    {

//        // Hay 2 ETAPAS de Juego: 
//        // 1- BEST OF FIVE KICKS
//        // 2- SUDDEN DEATH

//        // ETAPA:   1- BEST OF FIVE KICKS
//        // Se evalúa quién gana después de cada disparo (el de P1 y el de P2/CPU):
//        //
//        if ( (this._numeroOrdinalDeTurnoJugadorUNO <= (this._NUMERO_DE_TURNOS_POR_TANDA + 1) ) && (this._numeroOrdinalDeTurnoJugadorCPU <= (this._NUMERO_DE_TURNOS_POR_TANDA + 1) ) /* && ( this._numeroOrdinalDeTurnoJugadorUNO == this._numeroOrdinalDeTurnoJugadorCPU )*/ )
//        {

//            // P1 GANA a P2:
//            //  ('GOLES DE P1' >  'GOLES DE P2' + 'TURNOS POR JUGAR DE P2') ??
//            //
//            if ( this._golesAnotadosP1 > ( this._golesAnotadosP2 + ( this._NUMERO_DE_TURNOS_POR_TANDA + 1 - this._numeroOrdinalDeTurnoJugadorCPU ) ) )
//            {

//                // P1 ganó:
//                //
//                this._mainGameState = _GAME_STATES.BeatLevel;
            
//            }//End if
//            //
//            //  ('GOLES DE P2' >  'GOLES DE P1' + 'TURNOS POR JUGAR de P1') ??
//            //
//            else if ( this._golesAnotadosP2 > ( this._golesAnotadosP1 + ( this._NUMERO_DE_TURNOS_POR_TANDA + 1 - this._numeroOrdinalDeTurnoJugadorUNO ) ) )
//            {

//                // P2 ganó (el P1 Jugador PERDIÓ):
//                //
//                this._mainGameState = _GAME_STATES.Death;
            
//            }//End else del if

//        }//end if TANDA A 5
//        //
//        else
//        {
//            // 2- SUDDEN DEATH
//            //
//            // Se chequea   quién gana.
//            // Si NADIE gana: Pasar a otra RONDA ESPECIAL:   MUERTE SÚBITA.
//            //
//            // ETAPA:   2- SUDDEN DEATH
//            // Evaluar solo cuando ya chutó el jugador 2: CPU:  Es decir, cuando el número de #Turno P1 vs. #Turno P2 es igual.
//            // OJO: Si se acaba de Chutar: No se debe haber cambiado de Turno aún.
//            // PRERREQUISITO: Haber anotado el GOOOL recién disparado.
//            //
//            if ( this._numeroOrdinalDeTurnoJugadorUNO == this._numeroOrdinalDeTurnoJugadorCPU )
//            {

//                // GANA P1
//                //
//                if ( this._golesAnotadosP1 > this._golesAnotadosP2 )
//                {

//                    // P1 ganó:
//                    //
//                    this._mainGameState = _GAME_STATES.BeatLevel;

//                }//End if 
//                //
//                // GANA P2
//                //
//                else if ( this._golesAnotadosP2 > this._golesAnotadosP1 )
//                {

//                    // P2 ganó:
//                    //
//                    this._mainGameState = _GAME_STATES.Death;
                
//                }//End else if
//                //
////            else
////            {
////                // Pasar a OTRO ROUND ADICIONAL de MUERTE SÚBITA.
////                //
////                
////            }//

//            }//End if ( this._numeroOrdinalDeTurnoJugadorUNO == this._numeroOrdinalDeTurnoJugadorCPU )

//        }//End else del if (this._numeroOrdinalDeTurnoJugadorCPU <= (this._NUMERO_DE_TURNOS_POR_TANDA + 1))

//    }//End Metodo




//    /// <summary>
//    /// Chequea quien gana el juego (RETORNA => ''_JUGADORES.P1''... si es P1; ''_JUGADORES.CPU1''... si GANA P2/CPU...; _JUGADORES.NINGUNO... cuando NO GANA NADIE).
//    /// PRERREQUISITO:  Que ya se haya anotado el GOL y se actualizó el #NÚMERO TURNO del Jugador que acaba de Chutar.
//    /// </summary>
//    public _JUGADORES ChequearQuienGanaElJuego(int golesAnotadosP1, int numeroOrdinalDeTurnoJugadorUNO, int golesAnotadosP2, int numeroOrdinalDeTurnoJugadorDOS)
//    {

//        // Hay 2 ETAPAS de Juego: 
//        // 1- BEST OF FIVE KICKS
//        // 2- SUDDEN DEATH

//        // ETAPA:   1- BEST OF FIVE KICKS
//        // Se evalúa quién gana después de cada disparo (el de P1 y el de P2/CPU):
//        //
//        if ( (numeroOrdinalDeTurnoJugadorUNO <= (this._NUMERO_DE_TURNOS_POR_TANDA + 1) ) && (numeroOrdinalDeTurnoJugadorDOS <= (this._NUMERO_DE_TURNOS_POR_TANDA + 1) ) )
//        {

//            // P1 GANA a P2:
//            //  ('GOLES DE P1' >  'GOLES DE P2' + 'TURNOS POR JUGAR DE P2') ??
//            //
//            if ( golesAnotadosP1 > ( golesAnotadosP2 + ( this._NUMERO_DE_TURNOS_POR_TANDA + 1 - numeroOrdinalDeTurnoJugadorDOS ) ) )
//            {

//                // P1 ganó:
//                //
//                return _JUGADORES.P1;
            
//            }//End if
//            //
//            //  ('GOLES DE P2' >  'GOLES DE P1' + 'TURNOS POR JUGAR de P1') ??
//            //
//            else if ( golesAnotadosP2 > ( golesAnotadosP1 + ( this._NUMERO_DE_TURNOS_POR_TANDA + 1 - numeroOrdinalDeTurnoJugadorUNO ) ) )
//            {

//                // P2 ganó (el P1 Jugador PERDIÓ):
//                //
//                return _JUGADORES.CPU1;
            
//            }//End else del if

//        }//end if TANDA A 5
//        //
//        else
//        {
//            // 2- SUDDEN DEATH
//            //
//            // Se chequea   quién gana.
//            // Si NADIE gana: Pasar a otra RONDA ESPECIAL:   MUERTE SÚBITA.
//            //
//            // ETAPA:   2- SUDDEN DEATH
//            // Evaluar solo cuando ya chutó el jugador 2: CPU:  Es decir, cuando el número de #Turno P1 vs. #Turno P2 es igual.
//            // OJO: Si se acaba de Chutar: No se debe haber cambiado de Turno aún.
//            // PRERREQUISITO: Haber anotado el GOOOL recién disparado.
//            //
//            if ( numeroOrdinalDeTurnoJugadorUNO == numeroOrdinalDeTurnoJugadorDOS )
//            {

//                // GANA P1
//                //
//                if ( golesAnotadosP1 > golesAnotadosP2 )
//                {

//                    // P1 ganó:
//                    //
//                    return _JUGADORES.P1;

//                }//End if 
//                //
//                // GANA P2
//                //
//                else if ( golesAnotadosP2 > golesAnotadosP1 )
//                {

//                    // P2 ganó:
//                    //
//                    return _JUGADORES.CPU1;
                
//                }//End else if
//                //
////            else
////            {
////                // Pasar a OTRO ROUND ADICIONAL de MUERTE SÚBITA.
////                //
////                
////            }//

//            }//End if ( this._numeroOrdinalDeTurnoJugadorUNO == this._numeroOrdinalDeTurnoJugadorCPU )

//        }//End else del if (this._numeroOrdinalDeTurnoJugadorCPU <= (this._NUMERO_DE_TURNOS_POR_TANDA + 1))

//        // No Gana nadie:
//        //
//        return _JUGADORES.NINGUNO;

//    }//End Metodo



//    /// <summary>
//    /// Dice (retornando un //número > 0'') si el JUEGO está "a punto" de caramelo: i.e.: Alguien PODRÍA GANAR SI AL DISPARAR AHORA METE UN GOOOL!
//    /// PRERREQUISITO:  Que un Jugador esté por Chutar. OJO: #NÚMERO TURNO del Jugador va desde 1 (INICIAL).. hasta.. 6 (FINAL, CUANDO YA CHUTÓ LOS PRIMEROS 5 TURNOS),
//    ///...luego vendría la RONDA "SUDDEN DEATH" (desde #TURNO 6 (INICIAL).. hasta infinito).
//    /// RETORNA:  _JUGADORES: El ''ENUM'' correspondiente al JUGADOR (UNO-P1 o CPU-P2) que puede GANAR: si hay GOL o si se FALLA el gol.
//    /// </summary>
//    public _JUGADORES EstimarLaPosibilidadDeGanarOPerderEnTurnoSiguiente()
//    {

//        // Variable a retornar, veredicto final:
//        //
//        _JUGADORES numeroDeJugadorQuePodriaGanarSiHaceGOOOLEnTurnoSiguiente = _JUGADORES.NINGUNO;      // .NINGUNO= nadie; 
//        _JUGADORES numeroDeJugadorQuePodriaGanarSiFallaElGOLEnTurnoSiguiente = _JUGADORES.NINGUNO;     // .NINGUNO= nadie;


//        // 1- Determinar cuál Jugador será el siguiente (por Chutar), y su #Turno.
//        // Variables usadas:
//        // # TURNO / ROUND:
//        int numeroTurnoSiguienteDeJugadorUNO = this._numeroOrdinalDeTurnoJugadorUNO;
//        int numeroTurnoSiguienteDeJugadorDOS = this._numeroOrdinalDeTurnoJugadorCPU;
//        //
//        // # GOLes anotados:
//        //
//        int numeroGolesDeJugadorUNO = this._golesAnotadosP1;
//        int numeroGolesDeJugadorDOS = this._golesAnotadosP2;


//        // Decidir si Dispara: 1- P1 o.. 2- CPU
//        //
//        if (this._miJugadorActualQueChuta == this._miJugadorUNO)
//        {

//            // Estimados basados en el P1:
//            //
//            // 1- Simular un CHUTE de este jugador:
//            // 1.1- GOOOL!:
//            //
//            // Actualizar las variables para: SIMULAR QUE P1 USÓ 1 #TURNO MÁS + METIÓ UN GOL:
//            // # Turno:
//            //
//            numeroTurnoSiguienteDeJugadorUNO++;
//            //
//            // # Gol++:
//            //
//            numeroGolesDeJugadorUNO++;
//            //
//            // Ahora meter esas varibales en el METODO DE SIMULACION:
//            //
//            numeroDeJugadorQuePodriaGanarSiHaceGOOOLEnTurnoSiguiente = this.ChequearQuienGanaElJuego(numeroGolesDeJugadorUNO, numeroTurnoSiguienteDeJugadorUNO, numeroGolesDeJugadorDOS, numeroTurnoSiguienteDeJugadorDOS);


//            // 1.2- FALLAR EL GOL!: (no hacer gol)
//            //
//            // Actualizar las variables para: SIMULAR QUE P1 USÓ 1 #TURNO MÁS + NO METIÓ (UN GOL):
//            //
//            // # Gol++:
//            //
//            numeroGolesDeJugadorUNO--;
//            //
//            // Ahora meter esas variables en el METODO DE SIMULACION:
//            //
//            numeroDeJugadorQuePodriaGanarSiFallaElGOLEnTurnoSiguiente = this.ChequearQuienGanaElJuego(numeroGolesDeJugadorUNO, numeroTurnoSiguienteDeJugadorUNO, numeroGolesDeJugadorDOS, numeroTurnoSiguienteDeJugadorDOS);


//        }//End if (this._miJugadorActualQueChuta == this._miJugadorUNO)
//        //
//        else
//        {

//            // Estimados basados en el P2 = CPU:
//            //
//            // 1- Simular un CHUTE de este jugador:
//            // 1.1- GOOOL!:
//            //
//            // Actualizar las variables para: SIMULAR QUE P2 USÓ 1 #TURNO MÁS + METIÓ UN GOL:
//            // # Turno:
//            //
//            numeroTurnoSiguienteDeJugadorDOS++;
//            //
//            // # Gol++:
//            //
//            numeroGolesDeJugadorDOS++;
//            //
//            // Ahora meter esas varibales en el METODO DE SIMULACION:
//            //
//            numeroDeJugadorQuePodriaGanarSiHaceGOOOLEnTurnoSiguiente = this.ChequearQuienGanaElJuego(numeroGolesDeJugadorUNO, numeroTurnoSiguienteDeJugadorUNO, numeroGolesDeJugadorDOS, numeroTurnoSiguienteDeJugadorDOS);


//            // 1.2- FALLAR EL GOL!: (no hacer gol)
//            //
//            // Actualizar las variables para: SIMULAR QUE P1 USÓ 1 #TURNO MÁS + NO METIÓ (UN GOL):
//            //
//            // # Gol++:
//            //
//            numeroGolesDeJugadorDOS--;
//            //
//            // Ahora meter esas variables en el METODO DE SIMULACION:
//            //
//            numeroDeJugadorQuePodriaGanarSiFallaElGOLEnTurnoSiguiente = this.ChequearQuienGanaElJuego(numeroGolesDeJugadorUNO, numeroTurnoSiguienteDeJugadorUNO, numeroGolesDeJugadorDOS, numeroTurnoSiguienteDeJugadorDOS);


//        }//End else del if (this._miJugadorActualQueChuta == this._miJugadorUNO)


//        // Decidir si el Juego PODRÍA TERMINAR en este siguiente TURNO:
//        //
//        // Evaluación del caso que ocurre:
//        // GOL hace que ''PLAYER'' GANE??
//        //
//        if (numeroDeJugadorQuePodriaGanarSiHaceGOOOLEnTurnoSiguiente != _JUGADORES.NINGUNO)
//        {

//            // GANA si hay Goool:
//            //
//            return numeroDeJugadorQuePodriaGanarSiHaceGOOOLEnTurnoSiguiente;

//        }//end if
//        // FALLAR el disparo hace que ''PLAYER'' PIERDA??
//        //
//        else if (numeroDeJugadorQuePodriaGanarSiFallaElGOLEnTurnoSiguiente != _JUGADORES.NINGUNO)
//        {

//            // GANA otro si éste FALLA el Gol:
//            //
//            return numeroDeJugadorQuePodriaGanarSiFallaElGOLEnTurnoSiguiente;

//        }//end else
//        else
//        {
//            // Nadie Gana, nadie pierde aún (el Juego continúa):
//            //
//            return _JUGADORES.NINGUNO;

//        }//end else

//    }//End Metodo


//    #endregion Logica y Dinamica del Juego


//    #region Musica y Sonidos


//    #region Play Sound

//    /// <summary>
//    /// Ejecuta sonido de Silbato para chutar el Penalty.
//    /// </summary>
//    public void PlaySonidoSilbatazoCobrarPenalty()
//    {
//        // Play:
//        //
//        this._miAudioSourceSilbatazos.PlayOneShot( this._miSonidoSilbatazoCobrarPenalty );

//    }//End Metodo


//    /// <summary>
//    /// Ejecuta sonido elegido aleatoriamente de Comentario.
//    /// </summary>
//    public void PlaySonidoAleatorioBullaDeGooolOAbucheo( bool golOAbucheo )
//    {

//        if ( golOAbucheo )
//        {
//            // Gol
//            //
//            // Elige Sonido Aleatoriamente:
//            //
//            this._miAudioSourceBullaPublicoEmocionGol.clip = this._miListaSonidosBullaDeGOOOL[ Random.Range(0, this._miListaSonidosBullaDeGOOOL_Longitud  /*this._miListaSonidosBullaDeGOOOL.Length*/) ];

//        }//End if
//        else
//        {       
//            // No es Gol, ABUCHEO:
//            //
//            // Elige Sonido Aleatoriamente:
//            //
//            this._miAudioSourceBullaPublicoEmocionGol.clip = this._miListaSonidosBullaDeFallarElGOOOLAbucheo[ Random.Range(0, this._miListaSonidosBullaDeFallarElGOOOLAbucheo_Longitud   /* this._miListaSonidosBullaDeFallarElGOOOLAbucheo.Length */) ];

//        }//End else

//        // Play:
//        //
//        this._miAudioSourceBullaPublicoEmocionGol.PlayOneShot( this._miAudioSourceBullaPublicoEmocionGol.clip );

//    }//End Metodo


//    /// <summary>
//    /// Ejecuta sonido elegido aleatoriamente de Comentario.
//    /// </summary>
//    public void PlaySonidoAleatorioComentarista( AudioClip[] miListaDeSonidos, int miListaDeSonidos_Longitud )
//    {

//        // Elige Sonido Aleatoriamente:
//        //
//        this._miAudioSourceComentarista.clip = miListaDeSonidos[ Random.Range(0, miListaDeSonidos_Longitud  /* miListaDeSonidos.Length */) ];
//        //
//        // Play:
//        //
//        this._miAudioSourceComentarista.PlayOneShot( this._miAudioSourceComentarista.clip );

//    }//End Metodo


////    /// <summary>
////    /// Ejecuta sonido elegido aleatoriamente de Comentario.
////    /// </summary>
////    public void PlaySonidoAleatorioFuegosArtificiales()
////    {
////     
////        // Elige Sonido Aleatoriamente:
////        //
////        this._miAudioSourceFuegosArtificiales_1.clip = this._miListaDe[ Random.Range(0, this._miListaDe.Length) ];
////
////        // Play:
////        //
////        this._miAudioSourceBullaPublicoEmocionGol.PlayOneShot( this._miAudioSourceBullaPublicoEmocionGol.clip );
////
////    }//End Metodo


//    #region Sonidos de Animaciones de Portero

//    /// <summary>
//    /// Ejecuta sonido de Animación de Portero: Caerse para atrás.
//    /// </summary>
//    public void PlayActivarOdesactivarSombraDuranteAnimacionPortero( _JUGADORES miTipoJugador, bool activarOdesactivar )
//    {

//        // Sombra: Animar haciendo: Aparecer o Desaparecer.
//        //
//        if ( miTipoJugador == _JUGADORES.P1 )
//        {

//            // Esta ACTIVA LA SOMBRA?
//            //
//            if (GameManager.gm._miSombraDelPorteroP1 != null)
//            {

//                // Animar haciendo aparecer o desaparecer.
//                //
//                GameManager.gm._miScriptShadowsDynamicManager.UpdateShadowState(  GameManager._MI_INDICE_SOMBRA_DIN_PORTERO_P1, activarOdesactivar );

//            }//End if (GameManager.gm._miSombraDelPorteroP1 != null)

//        }
//        else if ( miTipoJugador == _JUGADORES.CPU1 )
//        {

//            // Esta ACTIVA LA SOMBRA?
//            //
//            if (GameManager.gm._miSombraDelPorteroCPU != null)
//            {

//                // Animar haciendo aparecer o desaparecer.
//                //
//                GameManager.gm._miScriptShadowsDynamicManager.UpdateShadowState(  GameManager._MI_INDICE_SOMBRA_DIN_PORTERO_CPU, activarOdesactivar );

//            }//End if (GameManager.gm._miSombraDelPorteroCPU != null)

//        }//End else if
////        else
////        {
////        }//End else

//    }//End Metodo


//    /// <summary>
//    /// Ejecuta sonido de Animación de Portero: Bailar como George... Big Salad.
//    /// </summary>
//    public void PlaySonidoAnimacionPortero_Bailar()
//    {
//        // Play:
//        //
//        this._miAudioSourceAnimacionesDelPortero.clip = this._miSonidoDeAnimacionDePortero_BailarComoBigSalad;
//        this._miAudioSourceAnimacionesDelPortero.Play();

//    }//End Metodo

//    /// <summary>
//    /// Ejecuta sonido de Animación de Portero: Crecer mucho, como un edificio.
//    /// </summary>
//    public void PlaySonidoAnimacionPortero_CrecerMucho()
//    {
//        // Play:
//        //
//        this._miAudioSourceAnimacionesDelPortero.clip = this._miSonidoDeAnimacionDePortero_CrecerMuchoComoEdificio;
//        this._miAudioSourceAnimacionesDelPortero.Play();

//    }//End Metodo


//    /// <summary>
//    /// Ejecuta sonido de Animación de Portero: Caerse para atrás.
//    /// </summary>
//    public void PlaySonidoAnimacionPortero_CaerseParaAtras()
//    {
//        // Play:
//        //
//        this._miAudioSourceAnimacionesDelPortero.clip = this._miSonidoDeAnimacionDePortero_CaerParaAtrasPLOP;
//        this._miAudioSourceAnimacionesDelPortero.Play();

//    }//End Metodo

//    /// <summary>
//    /// Ejecuta sonido de Animación de Portero: Caerse para atrás.
//    /// </summary>
//    public void PlaySonidoAnimacionPortero_CaerseParaAtrasConSombra( _JUGADORES miTipoJugador )
//    {
//        // Play:
//        //
//        this._miAudioSourceAnimacionesDelPortero.clip = this._miSonidoDeAnimacionDePortero_CaerParaAtrasPLOP;
//        this._miAudioSourceAnimacionesDelPortero.Play();

//        // Sombra: Animar haciendo desaparecer.
//        //
//        this.PlayActivarOdesactivarSombraDuranteAnimacionPortero( miTipoJugador, false );

//    }//End Metodo


//    /// <summary>
//    /// Ejecuta sonido de Animación de Portero: Rotar Horizontalmente.
//    /// </summary>
//    public void PlaySonidoAnimacionPortero_RotarHorizontalmente()
//    {
//        // Play:
//        //
//        this._miAudioSourceAnimacionesDelPortero.clip = this._miSonidoDeAnimacionDePortero_RotarHorizontalmente;
//        this._miAudioSourceAnimacionesDelPortero.Play();

//    }//End Metodo

//    /// <summary>
//    /// Ejecuta sonido de Animación de Portero: Hacerse chiquitico... hasta desaparecer.
//    /// </summary>
//    public void PlaySonidoAnimacionPortero_HacerseChiquiticoHastaDesaparecer()
//    {
//        // Play:
//        //
//        this._miAudioSourceAnimacionesDelPortero.clip = this._miSonidoDeAnimacionDePortero_HacerseChiquiticoHastaDesaparecer;
//        this._miAudioSourceAnimacionesDelPortero.Play();

//    }//End Metodo

//    /// <summary>
//    /// Ejecuta sonido de Animación de Portero: Hacerse chiquitico... hasta desaparecer.
//    /// </summary>
//    public void PlaySonidoAnimacionPortero_HacerseChiquiticoHastaDesaparecerConSombra( _JUGADORES miTipoJugador )
//    {
//        // Play:
//        //
//        this._miAudioSourceAnimacionesDelPortero.clip = this._miSonidoDeAnimacionDePortero_HacerseChiquiticoHastaDesaparecer;
//        this._miAudioSourceAnimacionesDelPortero.Play();

//        // Sombra: Animar haciendo desaparecer.
//        //
//        this.PlayActivarOdesactivarSombraDuranteAnimacionPortero( miTipoJugador, false );

//    }//End Metodo


//    /// <summary>
//    /// Detiene CUALQUIER Sonido de Animación de Portero.
//    /// </summary>
//    public void StopSonidoAnimacionPortero()
//    {

//        ////////Debug.LogWarning("\nOJO: 0 - ENTRÉ , pero NO HICE un ''StopSonidoAnimacionPortero()'' dentro de Script: ''GameManager.cs''\n");

//        if ( this._miAudioSourceAnimacionesDelPortero.isPlaying )
//        {
//            // Stop:
//            //
//            this._miAudioSourceAnimacionesDelPortero.Stop();

//            ////////Debug.LogWarning("\nOJO: 1 - SÍ HICE un ''StopSonidoAnimacionPortero()'' dentro de Script: ''GameManager.cs''\n");
//        }//End

//    }//End Metodo


//    /// <summary>
//    /// (MEJORA V2): Detiene CUALQUIER Sonido de Animación de Portero.
//    /// </summary>
//    public void StopSonidoAnimacionPorteroConSombra( _JUGADORES miTipoJugador )
//    {

//        ////////Debug.LogWarning("\nOJO: 0 - ENTRÉ , pero NO HICE un ''StopSonidoAnimacionPortero()'' dentro de Script: ''GameManager.cs''\n");

//        if ( this._miAudioSourceAnimacionesDelPortero.isPlaying )
//        {
//            // Stop:
//            //
//            this._miAudioSourceAnimacionesDelPortero.Stop();

//            ////////Debug.LogWarning("\nOJO: 1 - SÍ HICE un ''StopSonidoAnimacionPortero()'' dentro de Script: ''GameManager.cs''\n");
//        }//End


//        // Sombra: Animar haciendo RE-Aparecer (su estado normal).
//        //
//        this.PlayActivarOdesactivarSombraDuranteAnimacionPortero( miTipoJugador, true );

//    }//End Metodo

//    #endregion Sonidos de Animaciones de Portero


//    #endregion Play Sound


//    #region Sonidos Corrutinas (Multiples)

//    /// <summary>
//    /// Permite ejecutar una Corrutina que ejecutará 2 sonidos seguidos, uno despues de que el inicial termine.
//    /// Los sonidos son: Grito de GOOOL (o un Ouch! Ups!, etc), seguido de un aliento o ánimo al jugador.
//    /// </summary>
//    /// <returns>The sonido gol no gol v2.</returns>
//    IEnumerator PlaySonidoGolNoGolV2()
//    {

//        // Bandera de ""Falta reproducir sonido de Comentarista"":
//        //
//        this._faltaReproducirSonidoDeGol = false;

//        // Jugador actual que chutaba antes de que cambie:
//        //
//        _JUGADORES miJugadorActualQueChuta = this._miJugadorActualQueChuta;
//        //
//        // Estado en que estaba el Juego al meter el Gol-No-Gol:
//        //
//        _GAME_STATES_WHEN_PLAYING miGameStateAlIniciarEsteMetodo = this._gameStateWhenPlaying;


//        if (miGameStateAlIniciarEsteMetodo == _GAME_STATES_WHEN_PLAYING.CelebracionGol)
//        {

//            // Sonido de GOOOL! (en General)
//            //
//            // Índice Aleatorio:
//            //
//            int indiceAudioGol = Random.Range( 0, this._miListaDeSonidosComentarioDeGol_Longitud  /* this._miListaDeSonidosComentarioDeGol.Length */ );
//            //
//            this._miAudioSourceComentarista.clip = this._miListaDeSonidosComentarioDeGol[ indiceAudioGol ];
//            this._miAudioSourceComentarista.PlayOneShot( this._miAudioSourceComentarista.clip );
//            //
//            // Esperar hasta que termine de Reproducirse el Audio:
//            //  OJO: ESTO ES OPTIMIZABLE!!! VER https://unity3d.com/es/learn/tutorials/topics/performance-optimization/optimizing-garbage-collection-unity-games
//            //..SOBRE APARTADO:  COROUTINES (se puede "CACHEAR" al "new WaitForSeconds(...)"..)
//            //
//            yield return this._miListaDelayPlaySonidoGol_WaitForSeconds[ indiceAudioGol ]; /* = ÓPTIMO */   // No OPTIMIZADO: new WaitForSeconds(this._miAudioSourceComentarista.clip.length);


//            // Decidir si Dispara: 1- P1 o.. 2- CPU
//            //
//            if (miJugadorActualQueChuta == this._miJugadorUNO)
//            {

//                // Comentarios de ""Comentarista"" adicionales cuando HAY GOL, y uno es el afortunado en meterlo (FELICIDADES):
//                //
//                this._miAudioSourceComentarista.clip = this._miListaDeSonidosComentariosAlChutadorGol[ Random.Range(0, this._miListaDeSonidosComentariosAlChutadorGol_Longitud  /* this._miListaDeSonidosComentariosAlChutadorGol.Length */) ];
//                this._miAudioSourceComentarista.PlayOneShot( this._miAudioSourceComentarista.clip );

//            }//End if (this._miJugadorActualQueChuta == this._miJugadorUNO)
//            //
//            else
//            {

//                // Sonido de Ánimo porque hubo gol (P1 Portero)
//                //
//                this._miAudioSourceComentarista.clip = this._miListaDeSonidosComentariosDestructivosChutadorOPortero[ Random.Range(0, this._miListaDeSonidosComentariosDestructivosChutadorOPortero_Longitud  /* this._miListaDeSonidosComentariosDestructivosChutadorOPortero.Length */) ];
//                this._miAudioSourceComentarista.PlayOneShot( this._miAudioSourceComentarista.clip );

//            }//End else del if (this._miJugadorActualQueChuta == this._miJugadorUNO)

//        }
//        else if (miGameStateAlIniciarEsteMetodo == _GAME_STATES_WHEN_PLAYING.CelebracionNoEsGol)
//        {

//            // Sonido de FALLÓ!   NO-GOL! (en General)
//            //
//            // Índice Aleatorio:
//            //
//            int indiceAudio = Random.Range(0, this._miListaDeSonidosComentarioDeNoGol_Longitud  /* this._miListaDeSonidosComentarioDeNoGol.Length */);
//            //
//            this._miAudioSourceComentarista.clip = this._miListaDeSonidosComentarioDeNoGol[ indiceAudio ];
//            this._miAudioSourceComentarista.PlayOneShot( this._miAudioSourceComentarista.clip );
//            //
//            // Esperar hasta que termine de Reproducirse el Audio:
//            //  OJO: OPTIMIZABLE!!! https://unity3d.com/es/learn/tutorials/topics/performance-optimization/optimizing-garbage-collection-unity-games
//            //
//            yield return this._miListaDelayPlaySonidoNoGol_WaitForSeconds[ indiceAudio ]; /* = ÓPTIMO */  // new WaitForSeconds(this._miAudioSourceComentarista.clip.length);


//            // Decidir si Dispara: 1- P1 o.. 2- CPU
//            //
//            if (miJugadorActualQueChuta == this._miJugadorUNO)
//            {

//                // Comentarios de ""Comentarista"" adicionales cuando NO hay GOL, y uno es el CHUTADOR:
//                //
//                this._miAudioSourceComentarista.clip = this._miListaDeSonidosComentariosDestructivosChutadorOPortero[ Random.Range(0, this._miListaDeSonidosComentariosDestructivosChutadorOPortero_Longitud  /* this._miListaDeSonidosComentariosDestructivosChutadorOPortero.Length */) ];
//                this._miAudioSourceComentarista.PlayOneShot( this._miAudioSourceComentarista.clip );


//            }//End if (this._miJugadorActualQueChuta == this._miJugadorUNO)
//            //
//            else
//            {

//                // Sonido de FELICIDADES porque NO hubo gol (P1 Portero): Elogiar a P1 como un BUEN PORTERAZO:
//                //
//                this._miAudioSourceComentarista.clip = this._miListaDeSonidosComentariosAlPorteroSalvadaExitosa[ Random.Range(0, this._miListaDeSonidosComentariosAlPorteroSalvadaExitosa_Longitud  /* this._miListaDeSonidosComentariosAlPorteroSalvadaExitosa.Length */) ];
//                this._miAudioSourceComentarista.PlayOneShot( this._miAudioSourceComentarista.clip );

//            }//End else del if (this._miJugadorActualQueChuta == this._miJugadorUNO)

//        }//End else if (this._gameStateWhenPlaying == _GAME_STATES_WHEN_PLAYING.CelebrandoNoEsGol)

//    }//End Metodo


//    /// <summary>
//    /// Permite ejecutar una Corrutina que ejecutará 2 sonidos seguidos, uno despues de que el inicial termine.
//    /// Los sonidos son: Grito de GOOOL (o un Ouch! Ups!, etc), seguido de un aliento o ánimo al jugador.
//    /// </summary>
//    /// <returns>The sonido gol no gol v1.</returns>
//    IEnumerator PlaySonidoGolNoGol()
//    {

//        // Bandera de ""Falta reproducir sonido de Comentarista"":
//        //
//        this._faltaReproducirSonidoDeGol = false;

//        // Jugador actual que chutaba antes de que cambie:
//        //
//        _JUGADORES miJugadorActualQueChuta = this._miJugadorActualQueChuta;
//        //
//        // Estado en que estaba el Juego al meter el Gol-No-Gol:
//        //
//        _GAME_STATES_WHEN_PLAYING miGameStateAlIniciarEsteMetodo = this._gameStateWhenPlaying;


//        if (miGameStateAlIniciarEsteMetodo == _GAME_STATES_WHEN_PLAYING.CelebracionGol)
//        {

//            // Sonido de GOOOL! (en General)
//            //
//            this._miAudioSourceComentarista.clip = this._miListaDeSonidosComentarioDeGol[ Random.Range(0, this._miListaDeSonidosComentarioDeGol_Longitud  /* this._miListaDeSonidosComentarioDeGol.Length */) ];
//            this._miAudioSourceComentarista.Play();
//            //
//            // Esperar hasta que termine de Reproducirse el Audio:
//            //
//            yield return this._miListaDelayPlaySonidoGol_WaitForSeconds; /* = ÓPTIMO */  // new WaitForSeconds(this._miAudioSourceComentarista.clip.length);


//            // Decidir si Dispara: 1- P1 o.. 2- CPU
//            //
//            if (miJugadorActualQueChuta == this._miJugadorUNO)
//            {

//                // Comentarios de ""Comentarista"" adicionales cuando HAY GOL, y uno es el afortunado en meterlo (FELICIDADES):
//                //
//                this._miAudioSourceComentarista.clip = this._miListaDeSonidosComentariosAlChutadorGol[ Random.Range(0, this._miListaDeSonidosComentariosAlChutadorGol_Longitud  /* this._miListaDeSonidosComentariosAlChutadorGol.Length */) ];
//                this._miAudioSourceComentarista.Play();

//            }//End if (this._miJugadorActualQueChuta == this._miJugadorUNO)
//            //
//            else
//            {

//                // Sonido de Ánimo porque hubo gol (P1 Portero)
//                //
//                this._miAudioSourceComentarista.clip = this._miListaDeSonidosComentariosDestructivosChutadorOPortero[ Random.Range(0, this._miListaDeSonidosComentariosDestructivosChutadorOPortero_Longitud  /* this._miListaDeSonidosComentariosDestructivosChutadorOPortero.Length */) ];
//                this._miAudioSourceComentarista.Play();

//            }//End else del if (this._miJugadorActualQueChuta == this._miJugadorUNO)

//        }
//        else if (miGameStateAlIniciarEsteMetodo == _GAME_STATES_WHEN_PLAYING.CelebracionNoEsGol)
//        {

//            // Sonido de FALLÓ!   NO-GOL! (en General)
//            //
//            this._miAudioSourceComentarista.clip = this._miListaDeSonidosComentarioDeNoGol[ Random.Range(0, this._miListaDeSonidosComentarioDeNoGol_Longitud  /*  this._miListaDeSonidosComentarioDeNoGol.Length */) ];
//            this._miAudioSourceComentarista.Play();
//            //
//            // Esperar hasta que termine de Reproducirse el Audio:
//            //
//            yield return this._miListaDelayPlaySonidoNoGol_WaitForSeconds; /* = ÓPTIMO */  // new WaitForSeconds(this._miAudioSourceComentarista.clip.length);


//            // Decidir si Dispara: 1- P1 o.. 2- CPU
//            //
//            if (miJugadorActualQueChuta == this._miJugadorUNO)
//            {

//                // Comentarios de ""Comentarista"" adicionales cuando NO hay GOL, y uno es el CHUTADOR:
//                //
//                this._miAudioSourceComentarista.clip = this._miListaDeSonidosComentariosDestructivosChutadorOPortero[ Random.Range(0, this._miListaDeSonidosComentariosDestructivosChutadorOPortero_Longitud  /* this._miListaDeSonidosComentariosDestructivosChutadorOPortero.Length */) ];
//                this._miAudioSourceComentarista.Play();


//            }//End if (this._miJugadorActualQueChuta == this._miJugadorUNO)
//            //
//            else
//            {

//                // Sonido de FELICIDADES porque NO hubo gol (P1 Portero): Elogiar a P1 como un BUEN PORTERAZO:
//                //
//                this._miAudioSourceComentarista.clip = this._miListaDeSonidosComentariosAlPorteroSalvadaExitosa[ Random.Range(0, this._miListaDeSonidosComentariosAlPorteroSalvadaExitosa_Longitud  /* this._miListaDeSonidosComentariosAlPorteroSalvadaExitosa.Length */) ];
//                this._miAudioSourceComentarista.Play();

//            }//End else del if (this._miJugadorActualQueChuta == this._miJugadorUNO)

//        }//End else if (this._gameStateWhenPlaying == _GAME_STATES_WHEN_PLAYING.CelebrandoNoEsGol)

//    }//End Metodo


//    /// <summary>
//    /// Ejecuta los audios de Voz del Comentarista, para cuando se entrará en Fase de SUDDEN DEATH.
//    /// Permite ejecutar una Corrutina que ejecutará 2 sonidos seguidos, uno despues de que el inicial termine.
//    /// Los sonidos son: [Un BLOOPERS (o un Ouch! Ups!, etc), el cual śe ejecutará sólo en el 20% de las veces], seguido de un comentario correcto.
//    /// </summary>
//    /// <returns>Ejecuta los audios de Voz del Comentarista, para cuando se entrará en Fase de SUDDEN DEATH.</returns>
//    IEnumerator PlaySonidoComentariosParaEntrarEnSuddenDeath()
//    {
//        // CONCLUSIÓN: Debe reproducir el BLOOPER?
//        // Probabilidad de Reproducir el BLOOPER:
//        //
//        if ( Random.value <= this._miProbabilidadDeReproducirUnBlooperDeSuddenDeath)
//        {

//            // 0-   Poner el escenario en Blanco-Negro (es un ImageEffect, Asset descargado desde la Asset Store), para mayor dramatismo:
//            //
//            this._miScriptEfectoGrayscale.enabled = true;

//            // 1-   Sonido de BLOOPER! (primero)
//            //
//            /// Antes: this._miAudioSourceComentarista.clip = this._miSonidoComentario_Blooper_AlEntrarEnFaseDeSuddenDeath[ Random.Range(0, this._miSonidoComentario_Blooper_AlEntrarEnFaseDeSuddenDeath.Length) ];
//            // Optimizado:
//            //
//            this._miAudioSourceComentarista.clip = this._miSonidoComentario_Blooper_AlEntrarEnFaseDeSuddenDeath;
//            this._miAudioSourceComentarista.PlayOneShot( this._miAudioSourceComentarista.clip );
//            //
//            // Esperar hasta que termine de Reproducirse el Audio:
//            //
//            yield return this._miSonidoComentario_Blooper_AlEntrarEnFaseDeSuddenDeath_WaitForSeconds;    // new WaitForSeconds( this._miSonidoComentario_Blooper_AlEntrarEnFaseDeSuddenDeath  /* this._miAudioSourceComentarista.clip.length */);

//            // 2-   Restablecer el color-Effect del Escenario (Blanco-Negro-> a -> Normal):
//            //
//            this._miScriptEfectoGrayscale.enabled = false;

//        }//End if (Random.value <= this._miProbabilidadDeReproducirUnBlooperDeSuddenDeath)
//        //      
//        // 3-   Comentario versión normal, el que sonará siempre "obligatoriamente":
//        //
//        this._miAudioSourceComentarista.clip = this._miListaDeSonidosComentariosAlEntrarEnFaseDeSuddenDeath[ Random.Range(0, this._miListaDeSonidosComentariosAlEntrarEnFaseDeSuddenDeath_Longitud  /* this._miListaDeSonidosComentariosAlEntrarEnFaseDeSuddenDeath.Length */) ];
//        this._miAudioSourceComentarista.PlayOneShot( this._miAudioSourceComentarista.clip );

//        // Bandera de ""Falta reproducir sonido de Comentarista"":
//        //
//        this._faltaReproducirSonidoComentariosAlEntrarEnFaseDeSuddenDeath = false;

//    }//End Metodo


//    #endregion Sonidos Corrutinas (Multiples)


//    /// <summary>
//    /// Permite ejecutar un sonido, al Ganar o perder.
//    /// Los sonidos son:
//    /// [Si Ganas:   CONGRATULATIONS!, seguido de un aliento o ánimo al jugador para seguir jugando en el futuro.]
//    /// [Si pierdes: BETTER LUCK NEXT TIME!, seguido de un aliento o ánimo al jugador para seguir jugando en el futuro.]
//    /// </summary>
//    public void PlaySonidosGanarOPerderAlFinal()
//    {

//        // Bandera de ""Falta reproducir sonido de Comentarista"":
//        //
//        this._faltaReproducirSonidoAlFinalDeGanarOPerder = false;

//        // Estado del Juego (Jugar, Ganar Perder...)
//        //
//        ///_GAME_STATES miGameState = this._mainGameState;

//        // Decidir si GANÓ: 1- P1 o.. 2- CPU
//        //
//        if ( this._mainGameState == _GAME_STATES.BeatLevel )
//        {

//            // Comentarios de ""Comentarista"" cuando GANA P1: ( CONGRATULATIONS! ):
//            //
//            this._miAudioSourceComentarista.clip = this._miListaDeSonidosComentariosAlFinalAlGanar[ Random.Range(0, this._miListaDeSonidosComentariosAlFinalAlGanar_Longitud   /* this._miListaDeSonidosComentariosAlFinalAlGanar.Length */) ];

//        }//End if (this._miJugadorActualQueChuta == this._miJugadorUNO)
//        //
//        else if ( this._mainGameState == _GAME_STATES.Death )
//        {

//            // Comentarios de ""Comentarista"" cuando GANA P2/CPU: ( BETTER LUCK NEXT TIME! ):
//            //
//            this._miAudioSourceComentarista.clip = this._miListaDeSonidosComentariosAlFinalAlPerder[ Random.Range(0, this._miListaDeSonidosComentariosAlFinalAlPerder_Longitud  /* this._miListaDeSonidosComentariosAlFinalAlPerder.Length */) ];

//        }//End else del if (this._golesAnotadosP1 > this._golesAnotadosP2)

//        // PLAY!
//        //
//        this._miAudioSourceComentarista.PlayOneShot( this._miAudioSourceComentarista.clip );
                   
//    }//End Metodo

//    #endregion Musica y Sonidos


//    #region Animaciones de Personajes: PORTERO

//    /// <summary>
//    /// Permite setear el estado DEFAULT de la Animación (clip) de Portero.
//    /// </summary>
//    public void InicializarAnimacionDePorterosAEstadoDefaultIdle()
//    {
//        // Resetear Animaciones de 'Meter/Fallar GOOOL':
//        // DEFAULT:
//        //
//        if (this._miAnimatorPorteroPlayerP1.gameObject.activeSelf)
//        {
//            this._miAnimatorPorteroPlayerP1.SetTrigger( _PORTERO_IDLE_TRIGGER_PARAMETER_ANIMATION_STATE_HASH );
//        }
//        //
//        if (this._miAnimatorPorteroCPU.gameObject.activeSelf)
//        {
//            this._miAnimatorPorteroCPU.SetTrigger( _PORTERO_IDLE_TRIGGER_PARAMETER_ANIMATION_STATE_HASH );
//        }
//    }//End Metodo


//    /// <summary>
//    /// Permite ejecutar Animación de Portero, (elección aleatoria): Cuando detiene un GOL.
//    /// </summary>
//    public void IniciarAnimacionDePorteroAlDetenerUnGolEleccionAleatoria()
//    {
//        // Jugador actual que chutaba antes de que cambie:
//        //
//        ///// Optimización:     _JUGADORES miJugadorActualQueChuta = this._miJugadorActualQueChuta;
//        //
//        // Estado en que estaba el Juego al meter el Gol-No-Gol:
//        //
//        ///// Optimización:     _GAME_STATES_WHEN_PLAYING miGameStateAlIniciarEsteMetodo = this._gameStateWhenPlaying;

//        // Casos de GOL o NO-GOL:
//        //
//        if (this._gameStateWhenPlaying == _GAME_STATES_WHEN_PLAYING.CelebracionGol)
//        {

//            // Decidir si Dispara: 1- P1 o.. 2- CPU
//            //
//            if (this._miJugadorActualQueChuta == this._miJugadorUNO)
//            {

//                // Animación de cuando HAY GOL, y uno es el afortunado en meterlo (FELICIDADES):
//                // Animación: Portero CPU se lamenta:
//                // Aleatorizar:
//                // PENDIENTE.
//                //
//                /// CON UNA SOLA ANIMACION, SIN ALEATORIZAR:     this._miAnimatorPorteroCPU.SetTrigger( _PORTERO_NO_CELEBRA_CAEPARAATRAS_TRIGGER_PARAMETER_ANIMATION_STATE_HASH );
//                //
//                this._miAnimatorPorteroCPU.SetTrigger( this._miListaHashAnimacionesPorteroDeGoool[ Random.Range(0, this._miListaHashAnimacionesPorteroDeGoool_Longitud   /* this._miListaHashAnimacionesPorteroDeGoool.Length */) ] );


//                // Cámara: Hacer que siga o enfoque al Portero: CPU.
//                //
//                /////ANTES ERA: this._miScriptCamaraParaAnimacionDeGolOSalvadaEnfocarMuchosPuntosYMoverseAMuchosDestinos._miListaDeMetasAEnfocar[ this._miScriptCamaraParaAnimacionDeGolOSalvadaEnfocarMuchosPuntosYMoverseAMuchosDestinos._miListaDeMetasAEnfocar.Length - 1 ] = this._miPorteroCPU.transform;
//                //
//                this.HacerQueCamaraDeAnimacionDeGolONoGolEnfoqueSiempreA( this._miPorteroCPU_Cabeza_Transform  /* this._miPorteroCPU.transform.GetChild(0) */ );


//            }//End if (this._miJugadorActualQueChuta == this._miJugadorUNO)
//            //
//            else
//            {

//                // Animación de cuando HAY GOL, y el CPU es quien lo metió (PLAYER P1 se lamenta y era el Portero):
//                // Animación: Portero P1 Player, se lamenta:
//                // Aleatorizar:
//                // PENDIENTE.
//                //
//                /// CON UNA SOLA NIMACION, SIN ALEATORIZAR:     this._miAnimatorPorteroPlayerP1.SetTrigger( _PORTERO_NO_CELEBRA_CAEPARAATRAS_TRIGGER_PARAMETER_ANIMATION_STATE_HASH );
//                //
//                this._miAnimatorPorteroPlayerP1.SetTrigger( this._miListaHashAnimacionesPorteroDeGoool[ Random.Range(0, _miListaHashAnimacionesPorteroDeGoool_Longitud   /* this._miListaHashAnimacionesPorteroDeGoool.Length */) ] );


//                // Cámara: Hacer que siga o enfoque al Portero: P1, PLAYER HUMANO.
//                //
//                /////ANTES ERA: this._miScriptCamaraParaAnimacionDeGolOSalvadaEnfocarMuchosPuntosYMoverseAMuchosDestinos._miListaDeMetasAEnfocar[ this._miScriptCamaraParaAnimacionDeGolOSalvadaEnfocarMuchosPuntosYMoverseAMuchosDestinos._miListaDeMetasAEnfocar.Length - 1 ] = this._miPorteroHumano.transform;
//                //
//                this.HacerQueCamaraDeAnimacionDeGolONoGolEnfoqueSiempreA( this._miPorteroHumano_Cabeza_Transform  /* this._miPorteroHumano.transform.GetChild(0) */ );

//            }//End else del if (this._miJugadorActualQueChuta == this._miJugadorUNO)

//        }
//        else if (this._gameStateWhenPlaying == _GAME_STATES_WHEN_PLAYING.CelebracionNoEsGol)
//        {

//            // Decidir si Dispara: 1- P1 o.. 2- CPU
//            //
//            if (this._miJugadorActualQueChuta == this._miJugadorUNO)
//            {

//                // Animación de cuando NO HAY Gol, y uno es el CHUTADOR (lamento):
//                // Animación: Portero CPU CELEBRA:
//                // Aleatorizar:
//                // PENDIENTE.
//                //
//                //  this._miAnimatorPorteroCPU.SetTrigger( _PORTERO_CELEBRA_RODANDO_TRIGGER_PARAMETER_ANIMATION_STATE_HASH );
//                /////TAMBIEN ESTA:  this._miAnimatorPorteroCPU.SetTrigger( _PORTERO_CELEBRA_CRECIENDO_TRIGGER_PARAMETER_ANIMATION_STATE_HASH );
//                //
//                this._miAnimatorPorteroCPU.SetTrigger( this._miListaHashAnimacionesPorteroDeNoGol[ Random.Range(0, this._miListaHashAnimacionesPorteroDeNoGol_Longitud   /* this._miListaHashAnimacionesPorteroDeNoGol.Length */) ] );


//                // Cámara: Hacer que siga o enfoque al Portero: CPU.
//                //
//                /////ANTES ERA: this._miScriptCamaraParaAnimacionDeGolOSalvadaEnfocarMuchosPuntosYMoverseAMuchosDestinos._miListaDeMetasAEnfocar[ this._miScriptCamaraParaAnimacionDeGolOSalvadaEnfocarMuchosPuntosYMoverseAMuchosDestinos._miListaDeMetasAEnfocar.Length - 1 ] = this._miPorteroCPU.transform;
//                //
//                this.HacerQueCamaraDeAnimacionDeGolONoGolEnfoqueSiempreA( this._miPorteroCPU_Cabeza_Transform  /* this._miPorteroCPU.transform.GetChild(0) */ );


//            }//End if (this._miJugadorActualQueChuta == this._miJugadorUNO)
//            //
//            else
//            {

//                // Sonido de FELICIDADES porque NO hubo gol (P1 Portero): Elogiar a P1 como un BUEN PORTERAZO:
//                // Animación de cuando NO HAY Gol, y uno es el PORTERO que lo detuvo (FELICIDADES):
//                // Animación: Portero P1 Player CELEBRA:
//                // Aleatorizar:
//                // PENDIENTE.
//                //
//                //this._miAnimatorPorteroPlayerP1.SetTrigger( _PORTERO_CELEBRA_RODANDO_TRIGGER_PARAMETER_ANIMATION_STATE_HASH );
//                /////TAMBIEN ESTA:  this._miAnimatorPorteroPlayerP1.SetTrigger( _PORTERO_CELEBRA_CRECIENDO_TRIGGER_PARAMETER_ANIMATION_STATE_HASH );
//                //
//                this._miAnimatorPorteroPlayerP1.SetTrigger( this._miListaHashAnimacionesPorteroDeNoGol[ Random.Range(0, this._miListaHashAnimacionesPorteroDeNoGol_Longitud   /* this._miListaHashAnimacionesPorteroDeNoGol.Length */) ] );


//                // Cámara: Hacer que siga o enfoque al Portero: P1, PLAYER HUMANO.
//                //               
//                /////ANTES ERA: this._miScriptCamaraParaAnimacionDeGolOSalvadaEnfocarMuchosPuntosYMoverseAMuchosDestinos._miListaDeMetasAEnfocar[ this._miScriptCamaraParaAnimacionDeGolOSalvadaEnfocarMuchosPuntosYMoverseAMuchosDestinos._miListaDeMetasAEnfocar.Length - 1 ] = this._miPorteroHumano.transform;
//                //
//                this.HacerQueCamaraDeAnimacionDeGolONoGolEnfoqueSiempreA( this._miPorteroHumano_Cabeza_Transform  /* this._miPorteroHumano.transform.GetChild(0) */ );


//            }//End else del if (this._miJugadorActualQueChuta == this._miJugadorUNO)

//        }//End else if (this._gameStateWhenPlaying == _GAME_STATES_WHEN_PLAYING.CelebrandoNoEsGol)


//        // Inicio de Movimientos de Cámara junto con la Animación:
//        //
//        this._miScriptCamaraParaAnimacionDeGolOSalvadaEnfocarMuchosPuntosYMoverseAMuchosDestinos.Reinicializacion();

//    }//End Metodo


//    /// <summary>
//    /// Hacer que la Cámara de animacion de gol O no gol enfoque siempre a (miTransformGameObjectAEnfocar): 'cierto objeto pasado como parametro de entrada'.
//    /// </summary>
//    /// <param name="miTransformGameObjectAEnfocar">Mi transform game object A enfocar.</param>
//    public void HacerQueCamaraDeAnimacionDeGolONoGolEnfoqueSiempreA( Transform miTransformGameObjectAEnfocar )
//    {
//        // Longitud de Array de Enfoques de Camara:
//        //
//        /// Optimización:   int longitudArrayEnfoquescamara = this._miScriptCamaraParaAnimacionDeGolOSalvadaEnfocarMuchosPuntosYMoverseAMuchosDestinos._miListaDeMetasAEnfocar.Length;
//        //
//        // Optimzado:
//        //
//        int longitudArrayEnfoquescamara = this._miScriptCamaraParaAnimacionDeGolOSalvadaEnfocarMuchosPuntosYMoverseAMuchosDestinos._miListaDeMetasPosicionFinal_LongitudArray;

//        // Recorrer '_miListaDeMetasAEnfocar' con un FOR
//        //
//        for (int i = 0; i < longitudArrayEnfoquescamara; i++)
//        {

//            // Cámara: Hacer que siga o enfoque al Portero, sería lo ideal (objeto: 'miTransformGameObjectAEnfocar').
//            //               
//            this._miScriptCamaraParaAnimacionDeGolOSalvadaEnfocarMuchosPuntosYMoverseAMuchosDestinos._miListaDeMetasDeRotacionAEnfocar[ i ] = miTransformGameObjectAEnfocar;

//        }//End for

//    }//End Metodo

//    #endregion Animaciones de Personajes: PORTERO


//    #region Animacion de FIN de Juego: GANAR o PERDER

//    /// <summary>
//    /// Inicia la animacion al ganar o perder el juego. Fin de un Juego.
//    /// </summary>
//    public void IniciarAnimacionDeFinDeJuego(bool ganoOPerdio)
//    {

//        // 0-   Detener Animaciones de Camaras de instancias (objectos - Componentes dentro de GameObjects) de CÁMARAS
//        //
//        this.DetenerTodasLasAnimacionesDeCamaras();

//        // 2-   Animación de Letras que dicen: WIN o LOSE
//        //
//        if (ganoOPerdio)
//        {

//            // GANAR / WIN:
//            //
//            this._miScriptAnimacionesLetrasEnPantalla.IniciarAnimacionPlanoLetrasWINoLOSE_WIN_1_Inicial();

//        }//end if (ganandoOPerdiendo)
//        else
//        {
//            // PERDER / LOSE:
//            //
//            this._miScriptAnimacionesLetrasEnPantalla.IniciarAnimacionPlanoLetrasWINoLOSE_LOSE_1_Inicial();

//        }//end else

//        // Movimientos de la CÁMARA:
//        // 1- MOVIMIENTOS A POSICION INCIAL
//        // 2- MOVIMIENTO ANTIHORARIO CONSTANTE
//        //
//        StartCoroutine( this.PlayAnimacionDeFinDeJuegoParte2RotacionCamara() );


//        // 3-   Despliegue de Panel de RESULTADOS (Estadísticas de GOLES ANOTADOS, %%% DE EFICIENCIA, ETC)???
//        //

//    }//End Metodo


//    /// <summary>
//    /// Permite ejecutar una Corrutina que ejecutará la Parte II de la ''AnimacionDeFinDeJuego'': Rotación de la Cámara para tener una VISTA PANORÁMICA DEL ESCENARIO.
//    /// Los sonidos son: Grito de GOOOL (o un Ouch! Ups!, etc), seguido de un aliento o ánimo al jugador.
//    /// </summary>
//    IEnumerator PlayAnimacionDeFinDeJuegoParte2RotacionCamara()
//    {

//        // 1-   CAMARA: Inicio de Movimientos de Cámara junto con la Animación:
//        //
//        this._miScriptCamaraParaAnimacionAlGanarOPerderEnfocarMuchosPuntosYMoverseAMuchosDestinos.Reinicializacion();

//        // Esperar hasta que termine de Reproducirse la Animacion de camara de ''_miScriptCamaraParaAnimacionAlGanarOPerderEnfocarMuchosPuntosYMoverseAMuchosDestinos'':
//        //
//        yield return this._miScriptCamaraParaAnimacionAlGanarOPerderEnfocarMuchosPuntosYMoverseAMuchosDestinos_movermeAhora_WaitUntil;  // new WaitUntil(() => (! this._miScriptCamaraParaAnimacionAlGanarOPerderEnfocarMuchosPuntosYMoverseAMuchosDestinos._movermeAhora));

//        // Iniciar ROTACION de la Cámara en dirección Antihoraria: Vista Panorámica:
//        //
//        this._miScriptCamaraParaAnimacionAlGanarOPerderRotacionPanoramicaAlrededorDelMundo.enabled = true;

//    }//End Metodo

//    #endregion Animacion de FIN de Juego: GANAR o PERDER


//    #region Animaciones Parámetros Generales

//    /// <summary>
//    /// Detiene todas las Animaciones actuales de Movimientos de Cámaras automáticos del juego.
//    /// </summary>
//    public void DetenerTodasLasAnimacionesDeCamaras()
//    {

//        // 1-   CAMARA: ANIMACIÓN DE GANAR O PERDER
//        //
//        this._miScriptCamaraParaAnimacionAlGanarOPerderEnfocarMuchosPuntosYMoverseAMuchosDestinos.Reinicializacion();
//        this._miScriptCamaraParaAnimacionAlGanarOPerderEnfocarMuchosPuntosYMoverseAMuchosDestinos.enabled = false;

//        // 2-   CAMARA: ANIMACIÓN DE GOL/NO GOL.
//        //
//        this._miScriptCamaraParaAnimacionDeGolOSalvadaEnfocarMuchosPuntosYMoverseAMuchosDestinos.Reinicializacion();
//        this._miScriptCamaraParaAnimacionDeGolOSalvadaEnfocarMuchosPuntosYMoverseAMuchosDestinos.enabled = false;

//        // 3-   CAMARA: ANIMACIÓN DE PELIGRO DE GANAR O PERDER.
//        //
//        this._miScriptCamaraParaAnimacionDePeligroEnfocarMuchosPuntosYMoverseAMuchosDestinos.Reinicializacion();
//        this._miScriptCamaraParaAnimacionDePeligroEnfocarMuchosPuntosYMoverseAMuchosDestinos.enabled = false;

////        // -   CAMARA: ANIMACIÓN DE PELIGRO DE GANAR O PERDER.
////        //
////        this._miScriptCamaraEnfocarUnPuntoYMoverseADestinoChutar..Reinicializacion();
////        this._miScriptCamaraParaAnimacionDePeligroEnfocarMuchosPuntosYMoverseAMuchosDestinos.enabled = false;

//    }//End Metodo


//    public void IniciarOTerminarCamaraLenta(bool iniciarOTerminarCamaraLenta)
//    {
//        // Seteo de la cámara Lenta en base al parámetro de entrada 'iniciarOTerminarCamaraLenta' y a la variable pública '_miEscalaDeTiempoDeltaTimeCamaraLenta'
//        //
//        if (iniciarOTerminarCamaraLenta)
//        {
//            // Se pidió iniciar Cámara Lenta:
//            //
//            Time.timeScale = this._miEscalaDeTiempoDeltaTimeCamaraLenta[ (int) this._miDificultadDelJuegoElegida ];
//            //
//            //ORIGINAL: Time.fixedDeltaTime = this._MI_FIXED_DELTA_TIME_DE_FABRICA * Time.timeScale;
//            // OPTIMIZADO: 2019_11_01:
//            //
//            Time.fixedDeltaTime = this._miEscalaDeTiempoFixedDeltaTimeCamaraLentaFisicasYFixedUpdates;

//        }//end if
//        else
//        {
//            // Se pidió terminar la Cámara Lenta, y volver a velocidad NORMAL:
//            //
//            Time.timeScale = 1.0f;
//            Time.fixedDeltaTime = this._MI_FIXED_DELTA_TIME_DE_FABRICA;

//        }//end else

//    }//end Metodo


//    /// <summary>
//    /// Permite setear un PAUSE del Tiempo de Unity: Updates y FixedUpdates de cada Script y de la Física.
//    /// </summary>
//    /// <param name="pausarODespausar"></param>
//    public void PausarODespausarEscalaDeTiempo(bool pausarODespausar)
//    {
//        // Seteo del tiempo en Unity (OJO: Probar contra Bugs!)
//        //
//        if (pausarODespausar)    //true: Pausar
//        {

//            // Se pidió: Pausar:
//            //
//            Time.timeScale = 0f;
//            Time.fixedDeltaTime = 0f;     //this._MI_FIXED_DELTA_TIME_DE_FABRICA * Time.timeScale;
//            //
//            // Setear el Valor NUEVO del Trigger Instantáneo de este evento:
//            //
//            this._appCambiarDeEstadoTogglePauseODespause = false;  // !this._appCambiarDeEstadoTogglePauseODespause;
//            //
//            // Setear el NUEVO Valor del ESTADO: PAUSADO/DESPAUSADO
//            //
//            this._appEstaPausada = pausarODespausar;

//        }//end if
//        else
//        {

//            // Se pidió: DesPausar, volver a la Normalidad.
//            //
//            Time.timeScale = 1.0f;
//            Time.fixedDeltaTime = this._MI_FIXED_DELTA_TIME_DE_FABRICA;
//            //
//            // Setear el Valor NUEVO del Trigger Instantáneo de este evento:
//            //
//            this._appCambiarDeEstadoTogglePauseODespause = false;  // !this._appCambiarDeEstadoTogglePauseODespause;
//            //
//            // Setear el NUEVO Valor del ESTADO: PAUSADO/DESPAUSADO
//            //
//            this._appEstaPausada = pausarODespausar;

//        }//end else

//    }//end Metodo


//    //    /// <summary>
//    //    /// <para> Permite setear una CAMARA RAPIDA o CAMARA LENTA (solo para efectos de la FISICA DEL BALON, el resto se manejará mediante ""Time.unscaledDeltaTime"" y ""Time.fixedUnscaledDeltaTime"" ).</para>
//    //    /// <para>* parametroVelocidadDePasoDelTiempo :</para>
//    //    /// <para> == 1 VELOCIDAD NORMAL.</para>
//    //    /// <para></para>
//    //    /// <para> < 1 LENTO (Su piso parte desde CERO (0)).</para>
//    //    /// <para> > 1 RAPIDO (Su techo llega hasta un valor alto, por ejempo x10 veces lo normal. Se usará 10 como máximo (ver referencia de UNITY3D)).</para>
//    //    /// RETORNA:   TRUE si eran válidos los parámetros. || FALSE en caso Inválido (y no hace ningún cambio).
//    //    /// </summary>
//    //    public bool CambiarVelocidadDePasoDelTiempoGlobal(float parametroVelocidadDePasoDelTiempo)
//    //    {
//    //        // Seteo de la cámara Lenta en base al parámetro de entrada 'parametroVelocidadDePasoDelTiempo' y a la variable pública '_miEscalaDeTiempoDeltaTimeCamaraLenta'
//    //        // Validacion del parametro:
//    //        //
//    //        if ((parametroVelocidadDePasoDelTiempo < 0.0f) || (parametroVelocidadDePasoDelTiempo > 10.0f))
//    //        {
//    //            // Valores inválidos:
//    //            //
//    //            return false;
//    //
//    //        }//END if ((parametroVelocidadDePasoDelTiempo < 0.0f) || (parametroVelocidadDePasoDelTiempo > 10.0f))
//    //        else
//    //        {
//    //
//    //            // Es Válido el parámetro y será usado:
//    //            //
//    //            if (Time.timeScale != parametroVelocidadDePasoDelTiempo)
//    //            {
//    //                // Se pidió cambiar
//    //                //
//    //                Time.timeScale = parametroVelocidadDePasoDelTiempo;
//    //                Time.fixedDeltaTime = this._MI_FIXED_DELTA_TIME_DE_FABRICA * Time.timeScale;
//    //
//    //            }//end if
//    //            //
//    //            // Retornar: correcto!
//    //            //
//    //            return true;
//    //
//    //        }//end else del if ((parametroVelocidadDePasoDelTiempo < 0.0f) || (parametroVelocidadDePasoDelTiempo > 10.0f))
//    //
//    //    }//end Metodo

//    #endregion Animaciones Parámetros Generales


//    #region Configuracion del Juego


//    #region Pausa del Juego + Menu Pausa / Lets Play

//    public void PausarODespausarGeneralJuego( bool pausarODespausar )
//    {

//        // 1- Activar pausa o despausar
//        //
//        this.PausarODespausarEscalaDeTiempo( pausarODespausar );

//        // 2- Esconder por defecto el CANVAS del GameObject DE GUI de: Menú Pausa:
//        //
//        this.ActivarDesactivarCanvasGUIMenuPausaLetsPlayComponenteCanvas(pausarODespausar);     //this._miMenuPauseGUIComponenteCanvasEnGameObjectCanvas

//        // 3- Resetear Posición del Balón: Poner en el Centro: (OJO: Puede generar Bugs si ya se disparó la pelota y luego SE PIERDE EL TRACKING MARKER - antes de llegar a los Colliders de la Portería, etc.)
//        //
//        if (pausarODespausar)
//        {
//            // PAUSAR!
//            // 1-
//            // Hacer desaparecer y paralizar el Balón (cuando haya parado de hablar el Comentarista), para evitar Bugs raros:
//            //
//            if (this._miPlayer.activeInHierarchy)
//            {
//                // DES-Habilitar Balón (enable):
//                //
//                ///// this._miMicrophoneInputDelBalon._miConductaBalon.DesactivarYesconder();

//                // Ubicar en su lugar al BALÓN (en la LÍNEA DE META/GOL).
//                //
//                this._miScriptLineaDeGol.ReubicarElBalonEnPuntoDePenalty();

//            }//End if


//            // 2-   Garbage Collection:
//            // ABAJO código viejo:
//            //// 2.1- Indicar que se entró en un estado donde GC.Collect() no afectaría mucho el Performance.
//            ////
//            //this._puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance = true;
//            ////
//            //// 2.2- Ante el Peligro de que la App se quede guindada por GARBAGE: Enciendo el modo automatico:
//            ////
//            //_miGarbageCollectionManager.EnableGC_CleanGC();     // EnableGC_NoCleanGC();

//        }//End if (pausarODespausar)
//         //else
//         //{
//         //    // despausar!
//         //    //
//         //    // ABAJO código viejo que no es ÓPTIMO: (Porque provocaba HIPOS de performance al enfocar y des-enfocar rápido el Target)
//         //    //
//         //    //// 1-
//         //    //// Garbage Collection: Apago el modo automatico:    OJO con BUGs (momentos en los que se DES-PAUSE y NECESITE EL MODO Automatico).
//         //    ////
//         //    //_miGarbageCollectionManager.GCCollectApagandoGCautomatico();        //  DisableGC();
//         //    //// 2-
//         //    //// Indicar que se entró en un estado donde GC.Collect() SÍ afectaría mucho el Performance. NO SE PUEDE LIMPIAR AHORA.
//         //    ////
//         //    //this._puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance = false;

//        //}//end else del if (pausarodespausar)


//        // Garbage Collection:
//        //
//        // Mejorado el: 2019_09_19   (Porque provocaba HIPOS de performance al enfocar y des-enfocar rápido el Target)
//        //
//        // this.GarbageCollectionDentroDePausaODespausa( pausarODespausar );
//        //
//        // ////////////////////////
//        // Mejorado el 2019_09_20   (If inicial del Método sacado afuera para ahorrar 0.03 ms en Performance...)
//        // ////////////////////////
//        // PASOS:
//        // 1-
//        // Guardar valor de MEMORY HEAP (GARBAGE):
//        //
//        this._miMemoriaHeapGarbageActual = System.GC.GetTotalMemory(false);
//        //
//        /////Debug.LogWarning("GAMEMANAGER -> (antes de entrar) GarbageCollectionDentroDePausaODespausa() GC : Memory used before collection (miGarbageActual KB): this._miMemoriaHeapGarbageActual = " + this._miMemoriaHeapGarbageActual);
//        //
//        // CADA x (3?) minutos : Limpiar la GARBAGE. //No esto (demasiadas preguntas, no): verificar si la MEMORIA del Heap (basura) es mayor a 36 MB.
//        // 2-
//        //
//        if ((this._miTiempoParaInvocarGCCollect > _CONSTANTE_TIEMPO_MINIMA_N_SEGUNDOS_PUEDE_INVOCAR_GC_COLLECT) || (this._miMemoriaHeapGarbageActual > _TAMANO_HEAP_GARBAGE_MAXIMO_EMERGENCIA_BYTES))
//        {

//            // Invocar Limpieza:
//            //
//            this.GarbageCollectionDentroDePausaODespausa( pausarODespausar );

//        }//End if ((this._miTiempoParaInvocarGCCollect > _CONSTANTE_TIEMPO_MINIMA_N_SEGUNDOS_PUEDE_INVOCAR_GC_COLLECT) || (this._miMemoriaHeapGarbageActual > _TAMANO_HEAP_GARBAGE_MAXIMO_EMERGENCIA_BYTES))

//    }//End Metodo


//    #region En PAUSA-DESPAUSA: Update  Garbage Limpiar Garbage

//    /// <summary>
//    /// Metodo que decide (y ejecuta..) : si es necesario hacer un CG.Collect() al PAUSAR, o al DES-PAUSAR.
//    /// Razón de su existencia: Picos HORRIBLES en el PERFORMANCE al PAUSAR-DESPAUSAR. Esas pausas-despausas ocurren TAMBIÉN durante fracciones de segundo, al intentar enfocar la Portería, perdiendo de vista el IMAGE MARKER, usando el EXTENDED TRACKING.
//    /// CRITERIO (EXTRICTO): No hacer casi nunca la Limpieza: solo cuando la BASURA SEA "DEMASIADO" GRANDE.
//    /// </summary>
//    public void GarbageCollectionDentroDePausaODespausa(bool pausaOdespausa)
//    {

//        // Comentado la cabecera del IF INICIAL (porque se pregunta ANTES de entrar acá), para ahorrar en PERFORMANCE.
//        //
//        //// Guardar valor de MEMORY HEAP (GARBAGE):
//        ////
//        //this._miMemoriaHeapGarbageActual = System.GC.GetTotalMemory(false);
//        ////
//        //Debug.LogWarning("GAMEMANAGER -> GarbageCollectionDentroDePausaODespausa() GC : Memory used before collection (miGarbageActual KB): this._miMemoriaHeapGarbageActual = " + this._miMemoriaHeapGarbageActual);


//        //// CADA x (3?) minutos : Limpiar la GARBAGE. //No esto (demasiadas preguntas, no): verificar si la MEMORIA del Heap (basura) es mayor a 36 MB.
//        ////
//        //if ((this._miTiempoParaInvocarGCCollect > _CONSTANTE_TIEMPO_MINIMA_N_SEGUNDOS_PUEDE_INVOCAR_GC_COLLECT) || (this._miMemoriaHeapGarbageActual > _TAMANO_HEAP_GARBAGE_MAXIMO_EMERGENCIA_BYTES) )
//        //{


//        /////Debug.LogWarning("GAMEMANAGER GC : A punto de: EVALUANDO MOMENTOS... ");


//        // Evaluando MOMENTOS 
//        // ..para poder LIMPIAR: (BUENO, MAL MOMENTO o EMERGENCIA WHATEVER)...
//        //
//        if (this._puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance /*|| (((_mainGameState == _GAME_STATES.Playing) && ((this._gameStateWhenPlaying ==
//_GAME_STATES_WHEN_PLAYING.InicializacionFinalVariables) || (this._gameStateWhenPlaying ==
//_GAME_STATES_WHEN_PLAYING.PreparandoVariablesParaChutar))) || (_mainGameState == _GAME_STATES.GameOver))*/)
//        {
//            // Excelente Momento para LIMPIAR:
//            //
//            /////Debug.LogWarning("GAMEMANAGER -> GarbageCollectionDentroDePausaODespausa( pausaOdespausa = "+ pausaOdespausa + " ) GC : EVALUANDO MOMENTOS : Excelente Momento para LIMPIAR:");
//            //
//            if (pausaOdespausa)
//            {
//                // PAUSANDO...
//                //
//                // 1- LIMPIA + Ante el Peligro de que la App se quede guindada por GARBAGE: Enciendo el modo automatico:
//                //
//                _miGarbageCollectionManager.GCCollectApagandoGCautomatico();         // EnableGC_CleanGC();     // EnableGC_NoCleanGC();

//            }//End if (pausaOdespausa)
//            else
//            {
//                // DES-PAUSANDO...
//                //
//                // 1- Garbage Collection: Apago el modo automatico:    OJO con BUGs (momentos en los que se DES-PAUSE y NECESITE EL MODO Automatico).
//                //
//                _miGarbageCollectionManager.GCCollectApagandoGCautomatico();        //  DisableGC();

//            }//End else del if (pausaOdespausa)

//            // 2- Poner TIMER EN CERO otra vez. (En Ambos casos sirve: a- LIMPIADO: VOLVER A EMPEZAR .. (ESTA NO SE USA ACÁ:) -> b- NO LIMPIADO: Posponer).
//            //
//            this._miTiempoParaInvocarGCCollect = 0.0f;


//        }//End if ( this._puedeLimpiarEnEsteEstadoDelJuegoSinAfectarElPerformance || ...          
//        //else // 1- O no está en una FASE DE BAJO IMPACTO PERFORMANCE...                   
//        //{
//        //    // No implementado porque ya al PRINCIPIO SE PREGUNTA SI ES "CASO CRÍTICO, o no"...

//        //}//End if (GC.GetTotalMemory(false) /* miGarbageActual */ > _TAMANO_HEAP_GARBAGE_MAXIMO_EMERGENCIA_BYTES)


//        //}//End if ((this._miTiempoParaInvocarGCCollect > _CONSTANTE_TIEMPO_MINIMA_N_SEGUNDOS_PUEDE_INVOCAR_GC_COLLECT) || (this._miMemoriaHeapGarbageActual > _TAMANO_HEAP_GARBAGE_MAXIMO_EMERGENCIA_BYTES) )

//    }//End Method

//    #endregion En PAUSA-DESPAUSA: Update  Garbage Limpiar Garbage

//    #endregion Pausa del Juego + Menu Pausa / Lets Play


//    /// <summary>
//    /// DIFICULTAD
//    /// </summary>
//    public void InicializarDificultadDelJuego()
//    {
//        // Dada la DIFICULTAD del Juego SELECCIONADA desde el MENÚ PRINCIPAL,
//        // ..elegir la propia.
//        //
//        // 1- I.A. de CHUTADOR en gameOBJECT del Balón (ConductaIAChutadorDelPenalty.cs):
//        //
//        this._miScriptConductaIAChutadorDelPenalty._miNivelDeInteligencia = (ConductaIAChutadorDelPenalty._NIVEL_DE_INTELIGENCIA) this._miDificultadDelJuegoElegida;
//        //
//        this._miScriptConductaIAChutadorDelPenalty.InicializarVariablesIA();

//        // 2- I.A. de PORTERO en gameOBJECT del PorteroCPU (ConductaIAPortero.cs):
//        //
//        this._miScriptConductaPorteroCPU._miNivelDeInteligencia = (ConductaIAPortero._NIVEL_DE_INTELIGENCIA) this._miDificultadDelJuegoElegida;
//        //
//        this._miScriptConductaPorteroCPU.InicializarVariablesIA();


//        #region variables dependientes de la Dificultad del Juego

//        // Velocidad de las Físicas:
//        //
//        this._miEscalaDeTiempoFixedDeltaTimeCamaraLentaFisicasYFixedUpdates = this._MI_FIXED_DELTA_TIME_DE_FABRICA * this._miEscalaDeTiempoDeltaTimeCamaraLenta[(int)this._miDificultadDelJuegoElegida];


//        //Debug.Log
//        //
//        /////Debug.LogWarning(" FIXED DELTA TIME (this._miEscalaDeTiempoFixedDeltaTimeCamaraLentaFisicasYFixedUpdates) = " + this._miEscalaDeTiempoFixedDeltaTimeCamaraLentaFisicasYFixedUpdates);

//        #endregion

//    }//end Metodo


//    #region Configuracion Grafica - Pantalla

//    #region Configuracion Grafica Global

//    public void SetearConfiguracionGraficaGlobalSegunPoderDeDispositivo( int fpsFijado, _CALIDAD_DE_QUALITY_SETTINGS miCalidadDeQualitySettings )
//    {
//        // Make the game run at a good speed: 30 FPS for MOBILE and 60 FPS for PC.
//        //
//        Application.targetFrameRate = fpsFijado;
//        //
//        // Setear la CALIDAD DE LA APP en la variable (es un 'readonly'):
//        //
//        this._miCalidadDeQualitySettings = miCalidadDeQualitySettings;     // .MEDIUM = 2


//        // Solo cambiar la Calidad si el valor es:      .NON_INITIALIZED_INHERIT_FROM_ABOVE_METHODS
//        //
//        if ( miCalidadDeQualitySettings != _CALIDAD_DE_QUALITY_SETTINGS.NON_INITIALIZED_INHERIT_FROM_ABOVE_METHODS )
//        {

//            // Setear la CALIDAD DE LA APP:
//            // Set 'Quality Settings' FIXED to: MEDIUM: 2,... for instance.
//            //
//            QualitySettings.SetQualityLevel( (int) this._miCalidadDeQualitySettings );

//        }//End if ( miCalidadDeQualitySettings != _CALIDAD_DE_QUALITY_SETTINGS.NON_INITIALIZED_INHERIT_FROM_ABOVE_METHODS )


//        // 3.1- Obtener las Dimensiones de la Pantalla:
//        //
//        this._miTamanoPantallaX = Screen.width;
//        this._miTamanoPantallaY = Screen.height;
//        //
//        // Setear la 'Resolucion' a usar de Pantalla (width x heigh), dados los valores entrados como INPUT del usuario via Menu 
//        //...o atributo público de este Script: 'GameManager.cs'
//        //
//        this.SetResolucionDePantallaYAspectRatio( (int) this._miCalidadDeResolucionPantalla );

//    }//End Metodo


//    #endregion Configuracion Grafica Global

//    /// <summary>
//    /// Sets the resolucion de pantalla Y aspect ratio.
//    /// </summary>
//    /// <param name="nuevaResolucion">Nueva resolucion.</param>
//    public void SetResolucionDePantallaYAspectRatio (int calidadGraficaElegida)
//    {
//        // Nueva Resolucion:
//        //
//        float nuevaResolucion = ( calidadGraficaElegida / 100.0f );


//        /////Debug.Log("nuevaResolucion = " + nuevaResolucion);

//        /////Debug.Log("RESOLUCION DE PANTALLA ANTES de aplicar algo = " + Screen.currentResolution);

//        // Setear Nueva Resolucion:
//        //
//        Screen.SetResolution ((int)(this._miTamanoPantallaX * nuevaResolucion), (int)(this._miTamanoPantallaY * nuevaResolucion), true);
//        //
//        // Radio de Aspecto:   Deshabilitado por ahora, hasta probar y decidir si es buena idea, o no:
//        //
//        ///OPCION A: this._miCamara.aspect = this._miTamanoPantallaX / _miTamanoPantallaY;
//        // Fijar el ASPECT RATIO de la Cámara al mismo valor, por si acaso estaba perdiéndolo, debido a la línea anterior.
//        //
//        this._miCamaraRealDeLaApp.aspect = this._miTamanoPantallaX / this._miTamanoPantallaY;
//        //       
//        ///OPCION B (pero OJO: No sé si esta opción más bien des-hace la línea anterior): this._miCamara.ResetAspect();


////        ///////quitar/////ojo///////quitar/////ojo///////quitar/////ojo
////        //
////        if ( Screen.currentResolution.width >= ((int)(this._miTamanoPantallaX * nuevaResolucion)) )
////        {
////
////            this.LoadThisSceneAgain();
////
////        }//End if
////        ///////quitar/////ojo///////quitar/////ojo///////quitar/////ojo

//    }//End Method

//    #endregion Configuracion Grafica - Pantalla



//    #endregion Configuracion del Juego


////	public void Collect(int amount) 
////	{
////		_score += amount;
////
////		if (canBeatLevel)
////		{
////			mainScoreDisplay.text = _score.ToString () + " of "+beatLevelScore.ToString ();
////		} else {
////			mainScoreDisplay.text = _score.ToString ();
////		}
////	}


//    #region Control y Botones de Menu del Juego

//    /// <summary>
//    /// Load the Main Menu.
//    /// </summary>
//    public void LoadHomeMainMenu()
//    {
//        // Before: (Pre-Demo) SceneManager.LoadScene("SandBox1", LoadSceneMode.Single);

//        //        // DONT DO THIS. THROWS A WARNING and DOEŚN'T WORK:        // This line may not execute in modern UNITY3D Versions:  (Destroy)
//        //        //
//        //        this.DestroyActualScene();

//        /////Debug.Log("LoadHomeMainMenu()");


//        // Borrar la Basura:
//        //
//        // System.GC.Collect(); // Vieja implementación.
//        // Nueva: 2019/09/19:
//        //
//        _miGarbageCollectionManager.GCCollectApagandoGCautomatico();


//        // Load again active Scene:
//        //
//        SceneManager.LoadScene( /* Here WOULD BE the SCENE: ""MAIN MENU"". Temporary: Re-Load Active Scene */ SceneManager.GetActiveScene().name /* This Scene */, LoadSceneMode.Single);

//    }//End Method


//    /// <summary>
//    /// Loads and Initializes this scene again.
//    /// </summary>
//    public void LoadThisSceneAgain()
//    {

//        //        // DONT DO THIS. THROWS A WARNING and DOEŚN'T WORK:        // This line may not execute in modern UNITY3D Versions:  (Destroy)
//        //        //
//        //        this.DestroyActualScene();

//        /////Debug.Log("LoadThisSceneAgain()");

//        // Borrar la Basura:
//        //
//        // System.GC.Collect(); // Vieja implementación.
//        // Nueva: 2019/09/19:
//        //
//        _miGarbageCollectionManager.GCCollectApagandoGCautomatico();


//        // Load again active Scene:
//        //
//        SceneManager.LoadScene( /* This Scene: */ SceneManager.GetActiveScene().name, LoadSceneMode.Single);

//    }//End Method


//    /// <summary>
//    /// Destroys actual Scene, in order to call or Initialize another.
//    /// NOTE: It may not execute in modern UNITY3D Versions.
//    /// </summary>
//    public void DestroyActualScene()
//    {
//        // This line may not execute in modern UNITY3D Versions:  (Destroy)
//        //
//        SceneManager.UnloadSceneAsync( SceneManager.GetActiveScene().buildIndex );

//    }//End Method


////    // load the nextLevel after delay
////    IEnumerator LoadNextLevel() {
////        yield return new WaitForSeconds(2.5f);
////        SceneManager.LoadScene(levelAfterVictory);
////    }


//    #endregion Control y Botones de Menu del Juego

//    #region Utility y Miscelaneos

//    /// <summary>
//    /// Casts the int32 to string with no Garbage IF AND ONLY IF: It is bellow a DEFAULTED VALUE: 30 (it is using a constant ATTRIBUTE FROM THIS CLASS ABOVE.)
//    /// </summary>
//    public void CastIntToStringNoGarbage( int inputNumber, Text inputOutput )
//    {

//        if ( inputNumber <= _LENGTH_DE_NUMEROS_STRING_LIMITE_20 )
//        {
//            // It is bellow the MAX capacity of the string. It is OK to use  it.
//            //
//            inputOutput.text = _NUMEROS_STRING_LIMITE_20 [ inputNumber ];
//        }
//        else
//        {
//            // Generate Garbage, in the most optimized way (without using gstrings by vexe, or StringBuilder, which are way better):
//            //
//            inputOutput.text = inputNumber.ToString();

//        }//End else

//    }//End Method
        
//    #endregion Utility y Miscelaneos


//    #endregion Metodos que no son de Base de Unity

}
