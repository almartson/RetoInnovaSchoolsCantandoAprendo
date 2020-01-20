using System;
using UnityEngine;
//using System.Collections;
#if !UNITY_EDITOR
using UnityEngine.Scripting;
#endif

/// <summary>
/// GarbageCollectionManager
/// Mi Clase que es un CONTENEDOR DE MÉTODOS para la Limpieza de la Basura (Garbage Collection), generada por VUFORIA Pricipalmente (el NameSpace VuforiaBehaviour genera muchos GC.Alloc).
/// No es del Tipo MonoBehaviour, es decir, nada de: UPDATE, AWAKE, GetComponent... todo eso se hará en el GameManager, y si hace falta: se suscribirá a esos métodos al GameManager 
/// TODO (aún tengo que Googlear cómo hacer eso).
/// </summary>
public class GarbageCollectionManager
{
    #region Atributos


    public static GarbageCollectionManager _miGarbageCollectionManager;


    ///// <summary>
    ///// Constante que define el Tamano máximo del HEAP PERMITIDO antes de ejectuar una limpieza, i.e. llamada a GC.Collect()
    ///// </summary>
    //public const int _TAMANO_HEAP_GARBAGE_MAXIMO_EMERGENCIA_BYTES = 36000000; //50000000;

    ///// <summary>
    ///// (readonly): Descripción de la utilidad / uso de este Script. Ocasión en la que se usa.
    ///// </summary>
    //[Tooltip("(readonly): Descripción de la utilidad / uso de este Script. Ocasión en la que se usa.")]
    //public string _sirvoPara = "GarbageCollectionManager \nMi Clase que es un CONTENEDOR DE MÉTODOS para la Limpieza de la Basura (Garbage Collection), generada por VUFORIA Pricipalmente (el NameSpace VuforiaBehaviour genera muchos GC.Alloc). \nNo es del Tipo MonoBehaviour, es decir, nada de: UPDATE, AWAKE, GetComponent... todo eso se hará en el GameManager, \ny si hace falta: se suscribirá a esos métodos al GameManager (aún tengo que Googlear cómo hacer eso).";


    ///// <summary>
    ///// ESTADO CRONOMETRO.
    ///// </summary>
    //public enum _ESTADO_CRONOMETRO { Desactivado, ActivadoYaSeCumplioTiempo, ActivadoContando };

    ///// <summary>
    ///// Estado Particular del ""conteo de tiempo"".
    ///// </summary>
    //[Tooltip("Estado Particular del \"\"conteo de tiempo\"\".")]
    //public _ESTADO_CRONOMETRO _estadoConteoDelTiempo = _ESTADO_CRONOMETRO.Desactivado;

    ///// <summary>
    ///// ""Cantidad de Tiempo"" a contar.
    ///// </summary>
    //[Tooltip("\"\"Cantidad de Tiempo\"\" a contar.")]
    //public float _tiempoAContar = 1.0f;

    ///// <summary>
    ///// Tiempo transcurrido, desde que se inició el conteo / cronómetro.
    ///// </summary>
    //[Tooltip("Tiempo transcurrido, desde que se inició el conteo / cronómetro")]
    //public float _tiempoTranscurrido = 0.0f;

    #endregion Atributos


    #region Metodos de INICIALIZACION

    ///// <summary>
    ///// Constructor vacío temporal, después puede eliminarse o dejarse vacío.
    ///// Implementación actual: Reporta cambios en el Modo de GARBAGE COLLECTION: ON/OFF.
    ///// </summary>
    //static GarbageCollectionManager()
    //{
    //    //// Listen on garbage collector mode changes.
    //    ////
    //    //GarbageCollector.GCModeChanged += (GarbageCollector.Mode mode) =>
    //    //{
    //    //    //Debug.LogWarning("GC GCModeChanged: ------> " + mode);
    //    //};
    //}//End Constructor


    /// <summary>
    /// (Invocar en START - allí - o WAKE - no sé-) Metodo para Inicializar un HEAP GANDE, que pueda recibir mucha basura sin invocar al GC.Collect tan rápidamente ni frecuentemente.
    /// </summary>
    public /*static*/ void InicializarHeapAllocGrande() 
    {
        var tmp = new object[1024];

        // make allocations in smaller blocks to avoid them to be treated in a special way, which is designed for large blocks
        //
        for (int i = 0; i < 1024; i++)
        {
            tmp[i] = new byte[1024];

        }//End for

        // release reference
        tmp = null;


        /////Debug.LogWarning("GC : Ya se ejecutó el Método: InicializarHeapAllocGrande() ");

    }//End Metodo

    #endregion Metodos de INICIALIZACION


    #region Métodos Apagado/Encendido de Garbage Collection

    ///// <summary>
    ///// Comentar este Metodo para PRODUCCIÓN o cuando ya haya probado el GARBAGE COLLECTOR de esta Clase.
    ///// </summary>
    //public /*static*/ void LogMode()
    //{
    //    //Debug.LogWarning("GC GCMode: " + GarbageCollector.GCMode);
    //}


    /// <summary>
    /// Activar ( ON ) Garbage Collector + Limpia la Memoria de una Vez.
    /// OJO: No usar NUNCA, EXCEPTO en casos que quiera ver SANGRE (jejeje, mentira, digo: LIMPIEZA ERRÁTICA debido a VUFORIA - Genra Garbage e invoca él mismo a GARBAGE COLLECTOR..).
    /// </summary>
    public /*static*/ void EnableGC_CleanGC()
    {
        //Protegemos con una DIRECTIVA DE PRECOMPILACIÓN a la sentencia que DA ERROR en PLAYMODE del EDITOR
        //
#if !UNITY_EDITOR
        GarbageCollector.GCMode = GarbageCollector.Mode.Enabled;
#endif


        // Trigger a collection to free memory.
        //
        //Debug.LogWarning("GC : Memory used before collection: " + GC.GetTotalMemory(false) );
        //
        GC.Collect();
        //
        //Debug.LogWarning("GC : Memory used after full collection: " + GC.GetTotalMemory(true));

        /////Debug.LogWarning("GC : Ya se ejecutó el Método: EnableGC_CleanGC() ");

    }//End Method


    //    /// <summary>
    //    /// Activar ( ON ) Garbage Collector SIN Limpiar la Memoria.
    //    /// </summary>
    //    public /*static*/ void EnableGC_NoCleanGC()
    //    {
    //        //Protegemos con una DIRECTIVA DE PRECOMPILACIÓN a la sentencia que DA ERROR en PLAYMODE del EDITOR
    //        //
    //#if !UNITY_EDITOR
    //        GarbageCollector.GCMode = GarbageCollector.Mode.Enabled;
    //#endif

    //        /////Debug.LogWarning("GC : Ya se ejecutó el Método: EnableGC_NoCleanGC() ");

    //    }//End Method


    /// <summary>
    /// Desactivar ( OFF ) Garbage Collector
    /// </summary>
    public /*static*/ void DisableGC()
    {
        //Protegemos con una DIRECTIVA DE PRECOMPILACIÓN a la sentencia que DA ERROR en PLAYMODE del EDITOR
        //
#if !UNITY_EDITOR
        GarbageCollector.GCMode = GarbageCollector.Mode.Disabled;
#endif

        /////Debug.LogWarning("GC : Ya se ejecutó el Método: DisableGC() ");

    }//End Method


//    /// <summary>
//    /// Limpia la Basura, dejando encendido el modo automático. 
//    /// No usar, es mejor usar el "EnableGC_CleanGC".
//    /// </summary>
//    public /*static*/ void GCCollectDejandoEncendidoGCautomatico()
//    {

//#if !UNITY_EDITOR
//        if (GarbageCollector.GCMode == GarbageCollector.Mode.Enabled)
//#else
//        if (true)
//#endif
//        {
//            // Trigger a collection to free memory.
//            //
//            GC.Collect();

//            // Se muestra LOG, eliminar despues o comentar!!
//            //
//            /////Debug.LogWarning("GC : Ya se ejecutó el Método: GCCollectDejandoEncendidoGCautomatico() [OJO: en Editor PLAYMODE Puede NO FUNCIONAR]");

//        }//End if (GarbageCollector.GCMode == GarbageCollector.Mode.Enabled)
//        else
//        {
//            //Protegemos con una DIRECTIVA DE PRECOMPILACIÓN a la sentencia que DA ERROR en PLAYMODE del EDITOR
//            //
//#if !UNITY_EDITOR
//        GarbageCollector.GCMode = GarbageCollector.Mode.Enabled;
//#endif

//            // Se muestra LOG, eliminar despues o comentar!!
//            //
//            /////Debug.LogWarning("GC : Se entró al Método: GCCollectDejandoEncendidoGCautomatico(), pero se metió por el ELSE, y no hizo nada [(GarbageCollector.GCMode == GarbageCollector.Mode.Enabled) fue   FALSEEEE], \n pero ya lo activamos");

//        }//End else de if (GarbageCollector.GCMode == GarbageCollector.Mode.Enabled)

//    }//End Method


    /// <summary>
    /// Limpia la Basura, encendiendo y al final APAGANDO el modo automático (queda apagado).
    /// Se usa dentro del GameManager, en un Loop constante en el UPDATE().
    /// </summary>
    public /*static*/ void GCCollectApagandoGCautomatico()
    {

#if !UNITY_EDITOR
        GarbageCollector.GCMode = GarbageCollector.Mode.Enabled;
#endif

        // Trigger a collection to free memory.
        //
        GC.Collect();

        // Se muestra LOG, eliminar despues o comentar!!
        //
        /////Debug.LogWarning("GC : Ya se ejecutó el Método: GCCollectApagandoGCautomatico() [OJO: en Editor PLAYMODE Puede NO FUNCIONAR]");

        // Volvemos a apagar el Garbage Collector AUTOMATICO.
        //Protegemos con una DIRECTIVA DE PRECOMPILACIÓN a la sentencia que DA ERROR en PLAYMODE del EDITOR
        //
#if !UNITY_EDITOR
        GarbageCollector.GCMode = GarbageCollector.Mode.Disabled;
#endif

    }//End Method

    #endregion Métodos Apagado/Encendido de Garbage Collection


}