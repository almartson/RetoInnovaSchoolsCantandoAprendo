using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
/////using UnityEngine.Profiling;    // Profiler: COMENTAR CUANDO YA NO SE USE:

public class TweensScoreAvsBv3 : MonoBehaviour
{
    /// <summary>
    /// (readonly): Descripción de la utilidad / uso de este Script. Ocasión en la que se usa.
    /// </summary>
    [Tooltip("(readonly): Descripción de la utilidad / uso de este Script. Ocasión en la que se usa.")]
    public string _sirvoPara = "Clase para Métodos de SCORE RESULTANTE (por ejemplo: 0 - 1) de TWEENING / Animación de la GUI: CANVAS, UI TEXT, etc.";


    /// <summary>
    /// Time to complete one loop of the Tween.
    /// </summary>
    [Tooltip("Time to complete one loop of the Tween.")]
    //[Range(0.1f, 60.0f)]
    public static readonly float _miDuracionDeTiempo1CicloDeAnimacion = 0.75f;


    /// <summary>
    /// Grab a free Sequence to use
    /// </summary>
    private Sequence _miSecuencia_RotarVertical;

    /// <summary>
    /// Grab a free Sequence to use
    /// </summary>
    private Sequence _miSecuencia_AgrandarseLentamente;



    /// <summary>
    /// The MAIN tweener, which animates a single value.
    /// Se pone invisble por 1 segundo, luego reaparece.
    /// </summary>
    private Tweener _miTweener0_InvisiblePor1Segundo_1;

    /// <summary>
    /// The MAIN tweener, which animates a single value.
    /// Se pone invisble por 1 segundo, luego reaparece.
    /// </summary>
    private Tweener _miTweener0_InvisiblePor1Segundo_2;


    /// <summary>
    /// The MAIN tweener, which animates a single value.
    /// </summary>
    private Tweener _miTweener1_RotarVertical;

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

    private static readonly Vector3 _miVectorRotacionAlrededorDeEjeX = Vector3.right * 360.0f;    //Vector3.left * 67.5f;


    /// <summary>
    /// Nombres de ANIMACIONES en específico.
    /// </summary>
    public enum _ANIMACION { /*ROTAR_HORIZONTAL,*/ ROTAR_VERTICAL, AGRANDARSE };

    /// <summary>
    /// La ANIMACION a ejecutarse (i.e.: PLAY).
    /// </summary>
    //[HideInInspector]
    public _ANIMACION _miAnimacionParaPlay = _ANIMACION.ROTAR_VERTICAL;

    /// <summary>
    /// CONSTANTE de Número Probabilístico (en Base a 1.0f como CIEN PORCIENTO) que sirve para calcular los chances de tomar una ""decisión"" / ""acción"", basados en el NÚMERO DE DIFICULTADES O NIVELES DE I.A. (que son 3: BAJO - MEDIO - EXCELENTE).
    /// Este Número debe ser 0.333f si hay solo 3 Niveles de I.A..
    /// </summary>
    public static readonly int _NUMERO_DE_ANIMACIONES_DISPONIBLES = System.Enum.GetValues(typeof( _ANIMACION )).Length;


    // Constante:
    //
    private Vector3 _miVectorZero = Vector3.zero;




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

        // Settings
        // Grab a free Sequence to use
        //
        this._miSecuencia_RotarVertical = DOTween.Sequence()
            //.SetLoops(-1, LoopType.Restart)
            .SetSpeedBased(false)
            .SetAutoKill(false)
            // No necesario haceer 'polling': .SetRecyclable()
//            .OnPlay(()=>
//            {
//                /* Setear tipo de Animacion
//                */
//                this._miAnimacionParaPlay = _ANIMACION.ROTAR_VERTICAL;
//            })
        ;

        // Settings
        // Grab a free Sequence to use
        //
        this._miSecuencia_AgrandarseLentamente = DOTween.Sequence()
            //.SetLoops(-1, LoopType.Restart)
            .SetSpeedBased(false)
            .SetAutoKill(false)
            // No necesario haceer 'polling': .SetRecyclable()
//            .OnPlay(()=>
//            {
//                /* Setear tipo de Animacion
//                */
//                this._miAnimacionParaPlay = _ANIMACION.AGRANDARSE;
//            })

//            .OnPlay(() =>
//            {
//                this._miTransform.localScale = Vector3.zero;
//            })
//            ;
        ;

        // Inicializar Tweens (i.e.: Animaciones) y meterlos dentro de las Secuencias. Se dejan LISTOS para PLAY()!
        //
        this.InicializarSecuenciaRotarVertical();
        this.InicializarSecuenciaAgrandarseLentamente();

        #endregion Inicializar Secuencia

        // FIN.

    }//End Method Start


    #region MIS Metodos


    #region Inicializar Secuencias y Tweens

    /// <summary>
    /// Inicializa la secuencia: rotar vertical.
    /// </summary>
    private void InicializarSecuenciaRotarVertical()
    {
        // Prepara la Secuencia (Animaciones/Tweens al mismo tiempo):
        //
        // Tween Primario 0:
        //
        this._miTweener0_InvisiblePor1Segundo_1 = this._miTransform.DOBlendableScaleBy( /*-Vector3.one*/ new Vector3( -1.0f, -1.0f, -1.0f ) , _miDuracionDeTiempo1CicloDeAnimacion / 2.0f )    //DOScale( 0.0f, _miDuracionDeTiempo1CicloDeAnimacion / 4.0f /* _miDuracionDeTiempo1CicloDeAnimacion * 1.2f */ )   // ( 1.0f, _miDuracionDeTiempo1CicloDeAnimacion)
            .SetId(30)
            .SetDelay(0.0f)
            .SetEase(Ease.Linear)
            //.SetEase(Ease.InOutQuad)
            .SetLoops(2, LoopType.Yoyo)
            .SetRelative(false)
            //.From() // Esto provoca que el valor de arriba sea el valor 'inicial', y que la animacion vayapara atrás (a volverse pequeno)
            .SetSpeedBased(true)
            .SetAutoKill(false)
            // No necesario haceer 'polling': .SetRecyclable()
            ;


        // Rotacion Primaria:   HORIZONTAL: Sobre 'PLANO XZ'
        //
        this._miTweener1_RotarVertical = this._miTransform.DORotate( _miVectorRotacionAlrededorDeEjeX, _miDuracionDeTiempo1CicloDeAnimacion /*1.5f*/, RotateMode.Fast )
            .SetId(5)
            .SetDelay(0.0f)
            .SetEase(Ease.InQuad)
            //.SetEase(Ease.Linear)
            //
            .SetLoops(6, LoopType.Incremental)
            .SetRelative()  //SetRelative(true)
            .SetSpeedBased(false)
            .SetAutoKill(false)
            // No necesario haceer 'polling': .SetRecyclable()
            //.Pause()
            ;

        // Preparamos la Secuencia.
        // NOTA: Las Secuencias no inician automáticamente, asi que las iniciamos (cuando toque iniciarlas, con un DO.RESTART()):
        //
        // Append: coloca la primera animacion al principio de la Secuencia:
        //
        this._miSecuencia_RotarVertical.Append( this._miTweener0_InvisiblePor1Segundo_1 );
        //
        // 1- Append: coloca la primera animacion al principio de la Secuencia:
        //
        this._miSecuencia_RotarVertical.Append( this._miTweener1_RotarVertical );

//        // Color TWEEN: Will ONLY be used if there is AT LEAST ""ONE"" 'UI TEXT' GameObject (with 'Text' Component):
//        //
//        if ( this._miLongitudArrayDeUIText > 0)
//        {
//            // Inicializar new el Array de Tweeners de COLOR:
//            //
//            this._miTweener2_RotarVertical = new Tweener[this._miLongitudArrayDeUIText];
//
//
//            /////Profiler.BeginSample("miProfile MI_FOR_PRUEBA_DE_ALLOC_EN_TWEEN");
//
//            // Tween 2: Ejecutar al mismo tiempo:
//            // Tween de CAMBIO DE COLOR.
//            //
//            for (int i = 0; i < this._miLongitudArrayDeUIText; i++)
//            {
//                this._miTweener2_RotarVertical[ i ] = this._miArrayDeUIText[ i ].DOColor( this._miColorFinal, _miDuracionDeTiempo1CicloDeAnimacion ) /*DOBlendableColor( this._miColorFinal, _miDuracionDeTiempo1CicloDeAnimacion )*/
//                    .SetId(6)
//                    .SetDelay(0.0f)
//                    //.SetEase(Ease.InOutQuad)
//                    .SetEase(Ease.Linear)
//                    //
//                    .SetLoops(6, LoopType.Yoyo)
//                    //.From(false)    //.From()
//                    // NO PORQUE LO DEJA CAMBIADO AL TERMINAR: .SetRelative()  
//                    .SetRelative(false)
//                    .SetSpeedBased(false)
//                    .SetAutoKill(false)
//                    // No necesario haceer 'polling': .SetRecyclable()
//                    //.Pause()
//                ;
//
//                // Preparamos la Secuencia.
//                // NOTA: Las Secuencias no inician automáticamente, asi que las iniciamos (cuando toque iniciarlas, con un DO.RESTART()):
//                //
//                // 2-   Inserts the given tween at the same time position of the last tween or callback added to the Sequence
//                // (concurrent, parallel with all Tweens) for the whole duration of the Sequence:
//                //
//                this._miSecuencia_RotarVertical.Join( this._miTweener2_RotarVertical[ i ] );
//
//            }//end for    
//
//            /////Profiler.EndSample();
//
//        }//end if

        // Setear Estado Inicial como INICIAR. //""COMPLETED""
        //
        this._miSecuencia_RotarVertical.Rewind();  //.Complete();
            
    }//End Metodo     


    /// <summary>
    /// Inicializa la secuencia: Agrandarse Lentamente.
    /// </summary>
    private void InicializarSecuenciaAgrandarseLentamente()
    {
        // Prepara la Secuencia (Animaciones/Tweens al mismo tiempo):
        //
        // Estado Anterior: Tamano (ESCALA) Normal.

        // Tween Primario 0:
        //
        this._miTweener0_InvisiblePor1Segundo_2 = this._miTransform.DOScale( 0.0f, _miDuracionDeTiempo1CicloDeAnimacion * 0.66667f /* _miDuracionDeTiempo1CicloDeAnimacion * 1.2f */ )   // ( 1.0f, _miDuracionDeTiempo1CicloDeAnimacion)
            .SetId(27)
            .SetDelay(0.0f)
            .SetEase(Ease.Linear)
            //.SetEase(Ease.InOutQuad)
            .SetLoops(1, LoopType.Yoyo)
            .SetRelative(false)
            //.From() // Esto provoca que el valor de arriba sea el valor 'inicial', y que la animacion vayapara atrás (a volverse pequeno)
            .SetSpeedBased( true /*false*/)
            .SetAutoKill(false)
            // No necesario haceer 'polling': .SetRecyclable()
            ;


        // Tween Primario:
        //
        this._miTweener1_AgrandarseLentamente = this._miTransform.DOScale( 1.1f, _miDuracionDeTiempo1CicloDeAnimacion / 2.0f /* _miDuracionDeTiempo1CicloDeAnimacion * 1.2f */ )   // ( 1.0f, _miDuracionDeTiempo1CicloDeAnimacion)
            .SetId(7)
            .SetDelay(0.0f)
            .SetEase(Ease.InQuad)
            //.SetEase(Ease.InOutQuad)
            //.SetLoops(1, LoopType.Yoyo)
            .SetRelative(false)
            //.From() // Esto provoca que el valor de arriba sea el valor 'inicial', y que la animacion vayapara atrás (a volverse pequeno)
            .SetSpeedBased(false)
            .SetAutoKill(false)
            // No necesario haceer 'polling': .SetRecyclable()
            ;

        // Tween 3, al final:
        //
        this._miTweener3_AgrandarseLentamente = this._miTransform.DOShakePosition( _miDuracionDeTiempo1CicloDeAnimacion / 2.0f, 10.0f, 30, 90.0f, false, false )    // ( _miDuracionDeTiempo1CicloDeAnimacion / 2.0f, 10.0f, 21, 90.0f, false, false ) //Perfecto, aunque puedo bajarle un poco UNIFORMEMENTE: VIBRATO + STRENGTH: this._miTransform.DOShakePosition( _miDuracionDeTiempo1CicloDeAnimacion, 10.0f, 21, 90.0f, false, false ) // Muy Fuerte: this._miTransform.DOShakePosition( _miDuracionDeTiempo1CicloDeAnimacion, 21.0f, 52, 90.0f, false, false )
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
        this._miSecuencia_AgrandarseLentamente.Append( this._miTweener0_InvisiblePor1Segundo_2 );
        //
        // Append: coloca la primera animacion al principio de la Secuencia:
        //
        this._miSecuencia_AgrandarseLentamente.Append( this._miTweener1_AgrandarseLentamente );
        //
        // Append: coloca la animacion al final, después de la 'última', actualmente.
        //
        this._miSecuencia_AgrandarseLentamente.Append( this._miTweener3_AgrandarseLentamente );


//        // 2- COLOR BLEND: Only if there are UI TEXT GameOBJECTS:
//        //
//        if ( this._miLongitudArrayDeUIText > 0 )
//        {
//            // Inicializar el Array estatuco un valor fijo:
//            //
//            this._miTweener2_AgrandarseLentamente = new Tweener[ this._miLongitudArrayDeUIText ];
//
//            // Creacion de Tweeners de COLOR BLENDING:
//            //
//            for (int i = 0; i < this._miLongitudArrayDeUIText; i++)
//            {
//                // Tween 2, en paralelo con el anterior:
//                //
//                this._miTweener2_AgrandarseLentamente[ i ] = this._miArrayDeUIText[ i ].DOColor( this._miColorFinal, _miDuracionDeTiempo1CicloDeAnimacion * 2.0f ) /*DOBlendableColor( this._miColorFinal, _miDuracionDeTiempo1CicloDeAnimacion * 2.0f )*/
//                    .SetId(8)
//                    .SetDelay(0.0f)
//                    .SetEase(Ease.InQuad)
//                    //.SetEase(Ease.InOutQuad)
//                    //.SetEase(Ease.Linear)
//                    //
//                    .SetLoops(1)//, LoopType.Yoyo)
//                    //.From(/*false*/)
//                    //NO PORQUE LO DEJARÁ CON ESTE ESTADO SIEMPRE: VERDE: .SetRelative()  //SetRelative(true)
//                    .SetRelative(false)
//                    .SetSpeedBased(false)
//                    .SetAutoKill(false)
//                    // No necesario haceer 'polling': .SetRecyclable()
//                    //.Pause()
//                ;
//
//                // Preparamos la Secuencia.
//                // NOTA: Las Secuencias no inician automáticamente, asi que las iniciamos (cuando toque iniciarlas, con un DO.RESTART()):
//                //
//                // Inserts the given tween at the same time position of the last tween or callback added to the Sequence
//                // (concurrent, parallel with all Tweens) for the whole duration of the Sequence:
//                //
//                // Forma 1: this._miSecuencia.Join( this._miTweener2Paralelo );
//                //
//                this._miSecuencia_AgrandarseLentamente.Insert(0.0f, this._miTweener2_AgrandarseLentamente[ i ]);
//
//            }//end for
//
//        }//end if

        // Setear Estado Inicial como INICIAR: //""COMPLETED""
        //
        this._miSecuencia_AgrandarseLentamente.Rewind();    //.Complete();

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
    public void DO_Play_RotarVerticalmente(/*int id*/)
    {

        this._miSecuencia_RotarVertical.Play();

    }//End Method

    /// <summary>
    /// Plays a Sequence.
    /// </summary>
    public void DO_Play_AgrandarseLentamente(/*int id*/)
    {
        // Su estado inicial debe ser: DESAPARECIDO de la Pantalla:
        //
        this._miTransform.localScale = this._miVectorZero;
        //
        this._miSecuencia_AgrandarseLentamente.Play();

    }//End Method

    /// <summary>
    /// Restart a Sequence.
    /// </summary>
    public void DO_Restart_RotarVerticalmente(/*int id*/)
    {

        this._miSecuencia_RotarVertical.Restart();

    }//End Method

    /// <summary>
    /// Restart a Sequence.
    /// </summary>
    public void DO_Restart_AgrandarseLentamente(/*int id*/)
    {

//        // Stop all other Tweens / Sequences:
//        //
//        // NO: this._miSecuencia_RotarHorizontal.Rewind();
//        this._miSecuencia_RotarVertical.Rewind();
//
//        // Su estado inicial debe ser: DESAPARECIDO de la Pantalla:
//        //
//        this._miTransform.localScale = Vector3.zero;
        //
        this._miSecuencia_AgrandarseLentamente.Restart();

    }//End Method


    /// <summary>
    /// Completes all Sequences. Call it before a RESTART o REWIND on TWEENS tha are already playing.
    /// </summary>
    public void DO_Rewind_MyAnimations(/*int id*/)
    {
        this._miSecuencia_RotarVertical.Rewind();
        //
        // Estado de Tamano / Escala = 1.0f
        //
        /////No necesario: this._miTransform.localScale = Vector3.one;
        //
        this._miSecuencia_AgrandarseLentamente.Rewind();

    }//End Method


    /// <summary>
    /// Completes (FINISHES) all Sequences. Call it when you are about to HIDE the CANVAS, or before a RESTART o REWIND on TWEENS tha are already playing.
    /// </summary>
    public void DO_Stop_MyAnimations(/*int id*/)
    {
        // No: this._miSecuencia_RotarHorizontal.Complete();
        //
        this._miSecuencia_RotarVertical.Complete();
        this._miSecuencia_AgrandarseLentamente.Complete();
        //
        // Estado de Tamano / Escala = 1.0f
        // Inicializacion:
        //
        /////this._miTransform.localScale = Vector3.one;

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
    public void DO_Rewind_RotarVerticalmente(/*int id*/)
    {

        this._miSecuencia_RotarVertical.Rewind();

    }//End Method

    /// <summary>
    /// Rewind (REBOBINA) a Sequence AND PAUSES IT. Use it for Finishing the Animation, in a manner that enables it to continue in a later moment.
    /// </summary>
    public void DO_Rewind_AgrandarseLentamente(/*int id*/)
    {

        // Su estado inicial debe ser: DESAPARECIDO de la Pantalla:
        //
        ///// No: this._miTransform.localScale = Vector3.zero;
        //
        this._miSecuencia_AgrandarseLentamente.Rewind();

    }//End Method

    /// <summary>
    /// Pauses a Sequence.
    /// </summary>
    public void DO_Pause_RotarVerticalmente(/*int id*/)
    {

        this._miSecuencia_RotarVertical.Pause();

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
        // Rewind + Pause (Para dejar el STATUS DEL OBJECTO 'TARGET' de manera "neutral").
        //
        this.DO_Rewind_MyAnimations();
        //
        // Kill
        //
        this._miSecuencia_RotarVertical.Kill(false);
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
//        if (miAnimacionParaPlay == _ANIMACION.ROTAR_VERTICAL)
//        {
//
//            this.DO_Restart_RotarVerticalmente();
//
//        }//end else if (miAnimacionParaPlay == _ANIMACION.ROTAR_VERTICAL)
//        else if (miAnimacionParaPlay == _ANIMACION.AGRANDARSE)
//        {
//
//            this.DO_Restart_AgrandarseLentamente();
//
//        }//end else if (miAnimacionParaPlay == _ANIMACION.ROTAR_VERTICAL)
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

        if (this._miAnimacionParaPlay == _ANIMACION.ROTAR_VERTICAL)
        {

            this.DO_Restart_RotarVerticalmente();

        }//end else if (miAnimacionParaPlay == _ANIMACION.ROTAR_VERTICAL)
        else if (this._miAnimacionParaPlay == _ANIMACION.AGRANDARSE)
        {

            this.DO_Restart_AgrandarseLentamente();

        }//end else if (miAnimacionParaPlay == _ANIMACION.ROTAR_VERTICAL)
//        else
//        {
//
//        }//end else

    }//End Method

    #endregion PLAY (Interfaces de uso exterior - general)

    #endregion MIS Metodos

}
