using System;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;


namespace UnityStandardAssets.CrossPlatformInput
{
    [ExecuteInEditMode]
    public class MobileControlRig : MonoBehaviour
#if UNITY_EDITOR
        , UnityEditor.Build.IActiveBuildTargetChanged
#endif
    {
        // this script enables or disables the child objects of a control rig
        // depending on whether the USE_MOBILE_INPUT define is declared.

        // This define is set or unset by a menu item that is included with
        // the Cross Platform Input package.

        // Cache de Transforms, para mejor performance (2018/11/16):
        //
        /// <summary>
        /// Lista de GameObjects (BOTONES) que son: hijos del GameObject al que está pegado este Script.
        /// </summary>
        private GameObject[] _miListaDeGameObjectBotones;

        /// <summary>
        /// Longitud de la: Lista de GameObjects (BOTONES) que son: hijos del GameObject al que está pegado este Script.
        /// </summary>
        private int _miLogitudDeListaDeGameObjectBotones = 0;


#if !UNITY_EDITOR
	void OnEnable()
	{
		CheckEnableControlRig();
	}
#else
        public int callbackOrder
        {
            get
            {
                return 1;
            }
        }
#endif

        private void Start()
        {
#if UNITY_EDITOR
            if (Application.isPlaying) //if in the editor, need to check if we are playing, as start is also called just after exiting play
#endif
            {
                UnityEngine.EventSystems.EventSystem system = GameObject.FindObjectOfType<UnityEngine.EventSystems.EventSystem>();

                if (system == null)
                {//the scene have no event system, spawn one
                    GameObject o = new GameObject("EventSystem");

                    o.AddComponent<UnityEngine.EventSystems.EventSystem>();
                    o.AddComponent<UnityEngine.EventSystems.StandaloneInputModule>();
                }

                // 2018/11/16:
                //
                // Inicializar los GameOBJECT hijos DEL gAMEoBJECT QUE TIENE ESTE sCRIPT 'ATTACHEADO':
                //
                /////if ( ( this._miListaDeGameObjectBotones == null ) || ( this._miListaDeGameObjectBotones.Length <= 0 ) )
                //{

                // Obtener la Lista de GameOBJECTs hijos DEL gAMEoBJECT QUE TIENE ESTE sCRIPT 'ATTACHEADO':
                //
                Transform[] miListaDeTransforms = this.transform.GetComponentsInChildren<Transform>();
                //
                // Longitud del Array, cacheo:
                //
                this._miLogitudDeListaDeGameObjectBotones = miListaDeTransforms.Length;
                //
                this._miListaDeGameObjectBotones = new GameObject[this._miLogitudDeListaDeGameObjectBotones];

                // Extracción de los GAMEOBJECTs a partir de las TRANSFORMS:
                //
                for (int i = 0; i < this._miLogitudDeListaDeGameObjectBotones; i++)
                {
                    // Extraer el GameObject y asignárselo a una casilla del Array:
                    //
                    this._miListaDeGameObjectBotones[ i ] = miListaDeTransforms[ i ].gameObject;

                }//End for

                // Chequeo de ÚLTIMA HORA: Es != null ??
                //
                if ( this._miLogitudDeListaDeGameObjectBotones <= 0 )
                {
                    // Forma de Advertencia:
                    //
                    Debug.LogWarning("El Componente '_miListaDeGameObjectBotones' esta faltando dentro de este GameObject.\n...Y NO PODEMOS HAY SOLUCIÓN ALTERNA para el JOYSTICK.\n....Se deberá detener la ejecución");

                }//End if

                //}//End if ( ( this._miListaDeTransforms == null ) || ( this._miListaDeTransforms.Length <= 0 ) )

            }//End if

        }//End Method

#if UNITY_EDITOR

        private void OnEnable()
        {
            EditorApplication.update += CheckEnableControlRig;  // Update;
        }


        private void OnDisable()
        {
            EditorApplication.update -= CheckEnableControlRig;  // Update;
        }


//        private void Update()  //Optimizacion: Antes era:  Update()
//        {
//            // Para evitar alterar mucho el performance:
//            //
//            if ( ! EditorApplication.isPlaying )
//            {
//
//                // Check if Developer enabled / disabled the Control (Joystick) throught Code, in the EDITOR:
//                //
//                CheckEnableControlRig();
//
//            }//End if
//
//        }//End Method
#endif


        private void CheckEnableControlRig()
        {
#if MOBILE_INPUT
		EnableControlRig(true);
#else
            EnableControlRig(false);
#endif
        }


        // 2018/11/15:  DEPRECATED por mi: FOREACH esta muy unóptimo:
        //
//        private void EnableControlRig(bool enabled)
//        {
//            foreach (Transform t in transform)
//            {
//                t.gameObject.SetActive(enabled);
//            }
//        }


        // 2018/11/16: Versión optimizada V2.
        //
        private void EnableControlRig(bool enabled)
        {
            for (int i = 0; i < this._miLogitudDeListaDeGameObjectBotones; i++)
            {

                this._miListaDeGameObjectBotones[ i ].SetActive( enabled );

            }//End for
        }//End private void EnableControlRig(bool enabled)


#if UNITY_EDITOR
        public void OnActiveBuildTargetChanged(BuildTarget previousTarget, BuildTarget newTarget)
        {
            CheckEnableControlRig();
        }
#endif
    }
}