using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TweensRoundXv3 : MonoBehaviour
{
    /// <summary>
    /// (readonly): Descripción de la utilidad / uso de este Script. Ocasión en la que se usa.
    /// </summary>
    [Tooltip("(readonly): Descripción de la utilidad / uso de este Script. Ocasión en la que se usa.")]
    public string _sirvoPara = "Clase para Métodos de (ROUND X) de: TWEENING / Animación de la GUI: CANVAS, UI TEXT, etc.";


    /// <summary>
    /// Time to complete one loop of the Tween.
    /// </summary>
    [Tooltip("Time to complete one loop of the Tween.")]
    //[Range(0.1f, 60.0f)]
    public static readonly float _miDuracionDeTiempo1CicloDeAnimacion = 0.75f;


    //No es necesaria, ya que el Tweener solo tiene 1 (UN) TWEEN, no dos ni más...::::::::;
//    /// <summary>
//    /// Grab a free Sequence to use
//    /// </summary>
//    private Sequence _miSecuencia_RotarHorizontal;

    /// <summary>
    /// Grab a free Sequence to use
    /// </summary>
    private Sequence _miSecuencia_AgrandarseLentamente;


    /// <summary>
    /// The MAIN tweener, which animates a single value.
    /// </summary>
    private Tweener _miTweener1_RotarHorizontal;

    /// <summary>
    /// The MAIN tweener, which animates a single value.
    /// </summary>
    private Tweener _miTweener1_AgrandarseLentamente;

    /// <summary>
    /// The THIRD tweener (run in parallel with '_miTweener1' and '_miTweener2'), which animates a single value.
    /// </summary>
    private Tweener _miTweener3_AgrandarseLentamente;


    // Valores 'CACHEABLES' para mejor performance/optimización.

    /// <summary>
    /// Cache of transform, for later use.
    /// </summary>
    private Transform _miTransform;


    private static readonly Vector3 _miVectorRotacionAlrededorDeEjeY = Vector3.up * 180.0f;

    private static readonly Vector3 _miVector3Zero = Vector3.zero;

    private static readonly Vector3 _miVector3One = Vector3.one;


    /// <summary>
    /// Nombres de ANIMACIONES en específico.
    /// </summary>
    public enum _ANIMACION { ROTAR_HORIZONTAL, /* ROTAR_VERTICAL ,*/ AGRANDARSE };

    /// <summary>
    /// La ANIMACION a ejecutarse (i.e.: PLAY).
    /// </summary>
    //[HideInInspector]
    public _ANIMACION _miAnimacionParaPlay = _ANIMACION.ROTAR_HORIZONTAL;

    /// <summary>
    /// CONSTANTE de Número Probabilístico (en Base a 1.0f como CIEN PORCIENTO) que sirve para calcular los chances de tomar una ""decisión"" / ""acción"", basados en el NÚMERO DE DIFICULTADES O NIVELES DE I.A. (que son 3: BAJO - MEDIO - EXCELENTE).
    /// Este Número debe ser 0.333f si hay solo 3 Niveles de I.A..
    /// </summary>
    public static readonly int _NUMERO_DE_ANIMACIONES_DISPONIBLES = System.Enum.GetValues(typeof( _ANIMACION )).Length;



    // GOES PREVIOUSLY than "Start()".
    //
    private void Awake()
    {
        // Initialize with custom settings, and set capacities immediately
        //
        DOTween.Init(false /*true*/, false /* true */, LogBehaviour.ErrorsOnly).SetCapacity(25, 5);
        //
        // Set AUTO-PLAY to 'false'
        //
        DOTween.defaultAutoPlay = AutoPlay.None;


        // 1-   Cache de la TRANSFORM, para mejor performance.
        //
        this._miTransform = this.gameObject.GetComponent<Transform>();

    }//end method

    // Use this for initialization
    void Start()
    {
        #region Inicializar Secuencia

        // No necesaria, 1 TWEEN va adentro solamente::::
        //
//        // Settings
//        // Grab a free Sequence to use
//        //
//        this._miSecuencia_RotarHorizontal = DOTween.Sequence()
//            //.SetLoops(-1, LoopType.Restart)
//            .SetSpeedBased(false)
//            .SetAutoKill(false)
//            //// No necesario haceer 'polling': .SetRecyclable()
//        ;

        // Settings
        // Grab a free Sequence to use
        //
        this._miSecuencia_AgrandarseLentamente = DOTween.Sequence()
            //.SetLoops(-1, LoopType.Restart)
            .SetSpeedBased(false)
            .SetAutoKill(false)
            //// No necesario haceer 'polling': .SetRecyclable()
//            .OnPlay(()=>
//            {
//                /* Setear tipo de Animacion
//                */
//                this._miAnimacionParaPlay = _ANIMACION.AGRANDARSE;
//            })
//            ;

//            .OnPlay(() =>
//            {
//                this._miTransform.localScale = _miVector3Zero;    // Vector3.zero;
//            })
//            ;
        ;

        // Inicializar Tweens (i.e.: Animaciones) y meterlos dentro de las Secuencias. Se dejan LISTOS para PLAY()!
        //
        this.InicializarSecuenciaRotarHorizontal();
        this.InicializarSecuenciaAgrandarseLentamente();

        #endregion Inicializar Secuencia

        // FIN.

    }//End Method Start


    #region MIS Metodos


    #region Inicializar Secuencias y Tweens

    /// <summary>
    /// Inicializa la secuencia: rotar horizontal.
    /// </summary>
    private void InicializarSecuenciaRotarHorizontal()
    {
        // Prepara la Secuencia (Animaciones/Tweens al mismo tiempo):
        //
        // Rotacion Primaria:   VERTICAL: Sobre 'PLANO Y-X'
        //
        this._miTweener1_RotarHorizontal = this._miTransform.DORotate( _miVectorRotacionAlrededorDeEjeY, _miDuracionDeTiempo1CicloDeAnimacion * 2.0f /*3.0f*/, RotateMode.FastBeyond360 )
            .SetId(3)
            .SetDelay(0.0f)
            .SetEase(Ease.InOutQuad)
            .SetLoops(4, LoopType.Yoyo)
            .SetRelative()   //SetRelative(true)
            .SetSpeedBased(false)
            .SetAutoKill(false)
            //// No necesario haceer 'polling': .SetRecyclable()
            //.Pause()
//            .OnPlay(()=>
//            {
//                /* Setear tipo de Animacion
//                */
//                this._miAnimacionParaPlay = _ANIMACION.ROTAR_HORIZONTAL;
//            })
            ;

//        // Preparamos la Secuencia.
//        // NOTA: Las Secuencias no inician automáticamente, asi que las iniciamos (cuando toque iniciarlas, con un DO.RESTART()):
//        //
//        // Append: coloca la primera animacion al principio de la Secuencia:
//        //
//        this._miSecuencia_RotarHorizontal.Append( this._miTweener1_RotarHorizontal );

    }//End Metodo


    /// <summary>
    /// Inicializa la secuencia: Agrandarse Lentamente.
    /// </summary>
    private void InicializarSecuenciaAgrandarseLentamente()
    {
        // Prepara la Secuencia (Animaciones/Tweens al mismo tiempo):
        //
        // Estado Anterior: Tamano (ESCALA) Normal.

        // Tween Primario:
        //
        this._miTweener1_AgrandarseLentamente = this._miTransform.DOScale( 1.2f, _miDuracionDeTiempo1CicloDeAnimacion * 1.2f)
            .SetId(7)
            .SetDelay(0.0f)
            .SetEase(Ease.InQuad)
            //.SetEase(Ease.InOutQuad)
            //.SetLoops(1, LoopType.Yoyo)
            .SetRelative()
            //.From() // Esto provoca que el valor de arriba sea el valor 'inicial', y que la animacion vayapara atrás (a volverse pequeno)
            .SetSpeedBased(false)
            .SetAutoKill(false)
            //// No necesario haceer 'polling': .SetRecyclable()
            ;

        // Tween 3, al final:
        //
        this._miTweener3_AgrandarseLentamente = this._miTransform.DOShakePosition( _miDuracionDeTiempo1CicloDeAnimacion / 2.0f, 10.0f, 30, 90.0f, false, false ) //Perfecto, aunque puedo bajarle un poco UNIFORMEMENTE: VIBRATO + STRENGTH: this._miTransform.DOShakePosition( _miDuracionDeTiempo1CicloDeAnimacion, 10.0f, 21, 90.0f, false, false ) // Muy Fuerte: this._miTransform.DOShakePosition( _miDuracionDeTiempo1CicloDeAnimacion, 21.0f, 52, 90.0f, false, false )
            .SetId(9)
            .SetDelay(0.0f)
            //.SetEase(Ease.InQuad)
            .SetEase(Ease.Linear)
            //
            .SetLoops(1)    //, LoopType.Yoyo)
            .SetRelative()  //SetRelative(true)
            .SetSpeedBased(false)
            .SetAutoKill(false)
            // No necesario haceer 'polling': .SetRecyclable()
            ;

        // Preparamos la Secuencia.
        // NOTA: Las Secuencias no inician automáticamente, asi que las iniciamos (cuando toque iniciarlas, con un DO.RESTART()):
        //
        // Append: coloca la primera animacion al principio de la Secuencia:
        //
        this._miSecuencia_AgrandarseLentamente.Append( this._miTweener1_AgrandarseLentamente );
        //
        // Append: coloca la animacion al final, después de la 'última', actualmente.
        //
        this._miSecuencia_AgrandarseLentamente.Append( this._miTweener3_AgrandarseLentamente );

    }//End Metodo


    #endregion Inicializar Secuencias y Tweens


    #region EVERYTHING

    /// <summary>
    /// Plays all Tweens this GameObject has (together, at the same time).
    /// </summary>
    public void DO_PlayAllEverything(/*int id*/)
    {

        DOTween.PlayAll();

    }//End Method

    /// <summary>
    /// Restarts all Tweens this GameObject has (together, at the same time).
    /// </summary>
    public void DO_RestartAllEverything(/*int id*/)
    {

        DOTween.RestartAll();

    }//End Method

    /// <summary>
    /// Rewinds (i.e.: Restats and leaves PAUSED) all Tweens AND Sequences this GameObject has.
    /// </summary>
    public void DO_RewindAllEverything(/*int id*/)
    {

        DOTween.RewindAll();

    }//End Method

    #endregion EVERYTHING


    #region Play, Replay, Rewind, Kill

    /// <summary>
    /// Plays a Sequence.
    /// </summary>
    public void DO_Play_RotarHorizontal(/*int id*/)
    {

        // NO: this._miSecuencia_RotarHorizontal.Play();
        //
        this._miTweener1_RotarHorizontal.Play();

    }//End Method

    /// <summary>
    /// Plays a Sequence.
    /// </summary>
    public void DO_Play_AgrandarseLentamente(/*int id*/)
    {
        // Su estado inicial debe ser: DESAPARECIDO de la Pantalla:
        //
        this._miTransform.localScale = _miVector3Zero;   // Vector3.zero;
        //
        this._miSecuencia_AgrandarseLentamente.Play();

    }//End Method


    /// <summary>
    /// Restart a Sequence.
    /// </summary>
    public void DO_Restart_RotarHorizontal(/*int id*/)
    {

        // NO: this._miSecuencia_RotarHorizontal.Restart();
        //
        this._miTweener1_RotarHorizontal.Restart();

    }//End Method

    /// <summary>
    /// Restart a Sequence.
    /// </summary>
    public void DO_Restart_AgrandarseLentamente(/*int id*/)
    {

        // Stop all other Tweens / Sequences:
        //
        // NO: this._miSecuencia_RotarHorizontal.Rewind();
        this._miTweener1_RotarHorizontal.Rewind();

        // Su estado inicial debe ser: DESAPARECIDO de la Pantalla:
        //
        /////this._miTransform.localScale = _miVector3Zero   // Vector3.zero;
        //
        this._miSecuencia_AgrandarseLentamente.Restart();

    }//End Method


    /// <summary>
    /// Completes (FINISHES) all Sequences. Call it when you are about to HIDE the CANVAS, or before a RESTART o REWIND on TWEENS tha are already playing.
    /// </summary>
    public void DO_Rewind_MyAnimations(/*int id*/)
    {
        // No: this._miSecuencia_RotarHorizontal.Rewind();
        //
        this._miTweener1_RotarHorizontal.Rewind();
        //
        // Estado de Tamano / Escala = 1.0f
        //
        this._miTransform.localScale = _miVector3One;
        //
        this._miSecuencia_AgrandarseLentamente.Rewind();

    }//End Method


    /// <summary>
    /// Completes (FINISHES) all Sequences. Call it when you are about to HIDE the CANVAS, or before a RESTART o REWIND on TWEENS tha are already playing.
    /// </summary>
    public void DO_Stop_MyAnimations(/*int id*/)
    {
        // No: this._miSecuencia_RotarHorizontal.Rewind();
        //
        this._miTweener1_RotarHorizontal.Complete();
        this._miSecuencia_AgrandarseLentamente.Complete();
        //
        // Estado de Tamano / Escala = 1.0f
        //
        this._miTransform.localScale = _miVector3One;

    }//End Method

          
//    /// <summary>
//    /// Completes all Sequences. Call it before a RESTART o REWIND on TWEENS tha are already playing.
//    /// </summary>
//    public void DO_CompleteStop_MyAnimations(/*int id*/)
//    {
//        this._miSecuencia_RotarHorizontal.Complete();
//        this._miSecuencia_RotarVertical.Complete();
//        this._miSecuencia_AgrandarseLentamente.Complete();
//
//    }//End Method

    /// <summary>
    /// Rewind (REBOBINA) a Sequence AND PAUSES IT. Use it for Finishing the Animation, in a manner that enables it to continue in a later moment.
    /// </summary>
    public void DO_Rewind_RotarHorizontal(/*int id*/)
    {

        // No: this._miSecuencia_RotarHorizontal.Rewind();
        //
        this._miTweener1_RotarHorizontal.Rewind();

    }//End Method

    /// <summary>
    /// Rewind (REBOBINA) a Sequence AND PAUSES IT. Use it for Finishing the Animation, in a manner that enables it to continue in a later moment.
    /// </summary>
    public void DO_Rewind_AgrandarseLentamente(/*int id*/)
    {

        // Su estado inicial debe ser: DESAPARECIDO de la Pantalla:
        //
        ///// No: this._miTransform.localScale = _miVector3Zero;   // Vector3.zero;
        //
        this._miSecuencia_AgrandarseLentamente.Rewind();

    }//End Method


    /// <summary>
    /// Pauses a Sequence.
    /// </summary>
    public void DO_Pause_RotarHorizontal(/*int id*/)
    {

        // No: this._miSecuencia_RotarHorizontal.Pause();
        //
        this._miTweener1_RotarHorizontal.Pause();

    }//End Method

    /// <summary>
    /// Pauses a Sequence.
    /// </summary>
    public void DO_Pause_AgrandarseLentamente(/*int id*/)
    {

        this._miSecuencia_AgrandarseLentamente.Pause();

    }//End Method

    /// <summary>
    /// Kills all this class' Sequences.
    /// </summary>
    public void DO_Kill_AllMyTweeners()
    {
        // Completes (FINISHES) all Sequences. (Para dejar el STATUS DEL OBJECTO 'TARGET' de manera "neutral").
        //
        this.DO_Stop_MyAnimations();
        //
        // Kill
        //
        this._miTweener1_RotarHorizontal.Kill(false);
        this._miSecuencia_AgrandarseLentamente.Kill(false);

    }//End Method


    #endregion Play, Replay, Rewind, Kill


    #region PLAY (Interfaces de uso exterior - general)

//    /// <summary>
//    /// Plays a (Paused || Started || Rewinded || at least INITIALIZED) Animation.
//    /// </summary>
//    public void DO_PlayAnimacion(_ANIMACION miAnimacionParaPlay)
//    {
//
//        if (miAnimacionParaPlay == _ANIMACION.ROTAR_HORIZONTAL)
//        {
//
//            this.DO_Restart_RotarHorizontal();
//
//        }//end if (miAnimacionParaPlay == _ANIMACION.ROTAR_HORIZONTAL)
//        else if (miAnimacionParaPlay == _ANIMACION.AGRANDARSE)
//        {
//
//            this.DO_Restart_AgrandarseLentamente();
//
//        }//end else if (miAnimacionParaPlay == _ANIMACION.AGRANDARSE)
////        else
////        {
////
////        }//end else
//
//    }//End Method

    /// <summary>
    /// Plays (choosed RANDOMLY): a (Paused || Started || Rewinded || at least INITIALIZED) Animation. || numeroDeLoops: Si es mayor que CERO, será usado como el número de 
    ///..ITERACIONES del TWEEN/SECUENACIA/ANIMACION BASE.
    /// </summary>
    public void DO_PlayAnimacion()
    {
        // Numero Aleatorio de ID DE ANIMACION (+ Casteo a valor comparable de tipo _ANIMACION:):
        //
        this._miAnimacionParaPlay = (_ANIMACION) Random.Range(0, _NUMERO_DE_ANIMACIONES_DISPONIBLES);
        //
        // Casteo a valor comparable de tipo _ANIMACION:
        //
        //_ANIMACION miAnimacionParaPlayCasteada = (_ANIMACION)miAnimacionParaPlay;

        if (this._miAnimacionParaPlay == _ANIMACION.ROTAR_HORIZONTAL)
        {

            this.DO_Restart_RotarHorizontal();

        }//end if (miAnimacionParaPlay == _ANIMACION.ROTAR_HORIZONTAL)
        else if (this._miAnimacionParaPlay == _ANIMACION.AGRANDARSE)
        {

            this.DO_Restart_AgrandarseLentamente();

        }//end else if (miAnimacionParaPlay == _ANIMACION.AGRANDARSE)
//        else
//        {
//
//        }//end else

    }//End Method

    #endregion PLAY (Interfaces de uso exterior - general)

    #endregion MIS Metodos

}
