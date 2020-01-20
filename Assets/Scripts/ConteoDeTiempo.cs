using UnityEngine;

/// <summary>
/// Conteo de tiempo.
/// Clase que ""cuenta el tiempo"" trasncurrido, desde el ""momento exacto en el que setée"" (usar para eso la Variable """").
/// </summary>
public class ConteoDeTiempo : MonoBehaviour 
{

    /// <summary>
    /// ESTADO CRONOMETRO.
    /// </summary>
    public enum _ESTADO_CRONOMETRO { Desactivado, ActivadoYaSeCumplioTiempo, ActivadoContando };

    /// <summary>
    /// Estado Particular del ""conteo de tiempo"".
    /// </summary>
    [Tooltip("Estado Particular del \"\"conteo de tiempo\"\".")]
    public _ESTADO_CRONOMETRO _estadoConteoDelTiempo = _ESTADO_CRONOMETRO.Desactivado;

    /// <summary>
    /// ""Cantidad de Tiempo"" a contar.
    /// </summary>
    [Tooltip("\"\"Cantidad de Tiempo\"\" a contar.")]
    public float _tiempoAContar = 1.0f;

    /// <summary>
    /// Tiempo transcurrido, desde que se inició el conteo / cronómetro.
    /// </summary>
    [Tooltip("Tiempo transcurrido, desde que se inició el conteo / cronómetro")]
    public float _tiempoTranscurrido = 0.0f;



    private void Awake()
    {

        // Establecer el Estado del Script:
        //
        this._estadoConteoDelTiempo = _ESTADO_CRONOMETRO.Desactivado;

        // Apagar el Script para ahorrar memoria y CPU:
        //
        this.enabled = false;

    }//End Method

//    // No conviene usar.
//    private void Start() 
//    {
//        //
//        //
//        this.ReinicializarContador( true );
//
//    }//End Metodo



    private void Update() 
    {

        // Si el cronómetro está activado, en estado ""ActivadoContando"": trabajar.
        //
        if (this._estadoConteoDelTiempo == _ESTADO_CRONOMETRO.ActivadoContando)
        {

            // Contar el tiempo (SSI aún no se ha CUMPLDO EL PLAZO):
            //
            if (this._tiempoTranscurrido < this._tiempoAContar)
            {

                // Contar:
                //
                this._tiempoTranscurrido += Time.deltaTime;

            }//End if (this._tiempoTranscurrido < this._tiempoAContar)
            else
            {
                // Se cumplió el TIEMPO:               
                //
                this._estadoConteoDelTiempo = _ESTADO_CRONOMETRO.ActivadoYaSeCumplioTiempo;

                // Apagar el Script para ahorrar memoria y CPU:
                //
                this.enabled = false;

            }//end else

        }//End if (this._estadoConteoDelTiempo == _ESTADO_CRONOMETRO.ActivadoContando)

    }//End Metodo



    #region Metodos de INICIALIZACION

    /// <summary>
    /// Metodo para Inicializar las variables del Conteo de Tiempo, y prepararlo para un nuevo conteo.
    /// Puede invocarse con ""ponerElContadorEnCero"" en TRUE (y reinicializar a CERO a ""_tiempoTranscurrido"")
    /// .. o en FALSE (y servirá a modo de PAUSA en el conteo), pudiendo re-anudar el conteo más tarde, desde donde se dejó la última vez (poniendo la variable así:
    /// _estadoConteoDelTiempo = _ESTADO_CRONOMETRO.ActivadoContando; )
    /// </summary>
    /// <param name="ponerElContadorEnCero">If set to <c>true</c> poner el contador en cero.</param>
    ///
    public void ReinicializarContador(_ESTADO_CRONOMETRO estado, bool ponerElContadorEnCero, float duracionDeTiempoAContar) 
    {

        // Enciende el Script:
        //
        this.enabled = true;

        // Reinicializar estado
        //
        this._estadoConteoDelTiempo = estado;
        //
        this._tiempoAContar = duracionDeTiempoAContar;
        //
        if ( ponerElContadorEnCero )
        {

            this._tiempoTranscurrido = 0.0f;

        }//end if

    }//End Metodo

    /// <summary>
    /// Metodo para Inicializar las variables del Conteo de Tiempo, y prepararlo para un nuevo conteo.
    /// Puede invocarse con ""ponerElContadorEnCero"" en TRUE (y reinicializar a CERO a ""_tiempoTranscurrido"")
    /// .. o en FALSE (y servirá a modo de PAUSA en el conteo), pudiendo re-anudar el conteo más tarde, desde donde se dejó la última vez (poniendo la variable así:
    /// _estadoConteoDelTiempo = _ESTADO_CRONOMETRO.ActivadoContando; )
    /// </summary>
    /// <param name="ponerElContadorEnCero">If set to <c>true</c> poner el contador en cero.</param>
    ///
    public void ReinicializarContador(bool ponerElContadorEnCero) 
    {
        // Enciende el Script:
        //
        this.enabled = true;

        // Reinicializar estado
        //
        this._estadoConteoDelTiempo = _ESTADO_CRONOMETRO.Desactivado;
        //
        //SE DEJA LA VARIABLE "DURACION" COMO ESTABA:  this._tiempoAContar;
        //
        if ( ponerElContadorEnCero )
        {

            this._tiempoTranscurrido = 0.0f;

        }//end if

    }//End Metodo


    /// <summary>
    /// Interfaz para se usada desde afuera (en Objetos y Scripts ajenos a este código) estilo CAJA NEGRA.
    /// Simplemente elige los parámetros, .. y voilá.
    /// Cuenta el Tiempo estilo CRONÓMETRO.
    /// Cuando esté listo: La variable es así (PREGUNTAR POR ELLA EN UN 'IF'): ""this._estadoConteoDelTiempo = _ESTADO_CRONOMETRO.ActivadoYaSeCumplioTiempo;""
    /// </summary>
    public void IniciarConteo( bool ponerElContadorEnCero, float duracionDeTiempoAContar ) 
    {

        // Activar estado
        //
        this.ReinicializarContador(_ESTADO_CRONOMETRO.ActivadoContando, ponerElContadorEnCero, duracionDeTiempoAContar); 

    }//End Metodo

    /// <summary>
    /// Pone a andar el CRONÓMETRO con los parámetros dados previamente. SE ASUME  QUE EN EL INSPECTOR O EN OCASIÓN PREVIA YA SE SETEARON.
    /// Hace esto: ""this._estadoConteoDelTiempo = _ESTADO_CRONOMETRO.ActivadoContando;""
    /// 
    /// Interfaz para se usada desde afuera (en Objetos y Scripts ajenos a este código) estilo CAJA NEGRA.
    /// Cuenta el Tiempo estilo CRONÓMETRO.
    /// Cuando esté listo: La variable es así (PREGUNTAR POR ELLA EN UN 'IF'): ""this._estadoConteoDelTiempo = _ESTADO_CRONOMETRO.ActivadoYaSeCumplioTiempo;""
    /// </summary>
    public void IniciarConteo() 
    {

        // Activar estado
        //
        this._estadoConteoDelTiempo = _ESTADO_CRONOMETRO.ActivadoContando;

    }//End Metodo


    public void PausarConteo() 
    {

        // Pausar (hasta nuevo aviso) estado
        //
        this._estadoConteoDelTiempo = _ESTADO_CRONOMETRO.Desactivado;

    }//End Metodo

    #endregion Metodos de INICIALIZACION

}