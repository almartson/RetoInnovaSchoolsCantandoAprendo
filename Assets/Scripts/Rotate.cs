using UnityEngine;


public class Rotate : MonoBehaviour {

	// the speed of the rotation
	public float speed = 10.0f;

	// setup the possible rotation states
	public enum whichWayToRotate {AroundX, AroundY, AroundZ}

	// set the direction of the rotation
	public whichWayToRotate way = whichWayToRotate.AroundX;

   
    // Optimizadores:

    /// <summary>
    /// Mi transform. Caché para no desperdiciar el performance.
    /// </summary>
    private Transform _miTransform;

//    // Rotaciones:
//
//    // X:
//    private Vector3 _miVector3Right = Vector3.right;
//
//    // Y:
//    private Vector3 _miVector3Up = Vector3.up;
//
//    // Z:
//    private Vector3 _miVector3Forward = Vector3.forward;


    /// Mi vector Auxiliar direccionado (OPTIMIZACIÓN PARA EVITAR TENER QUE MULTIPLICAR POR speed EN CADA frame)
    ///
    private Vector3 _miVector3SpeedDireccionado; // = new Vector3 (0.0f, 0.0f, 0.0f);


//    /// <summary>
//    /// Whether or Not you want to set a START TRANSFORM: (x, y, z). Useful if it is attached to a Camera: This Script can adjust the rotation to some value (e.g.: looking straight at the Horizon).
//    /// </summary>
//    [Tooltip("Value (x, y, z) If it is a Camera: This Script can adjust the rotation to some value (e.g.: looking straight at the Horizon).")]
//    public bool[] _wantToAdjustStartCoordenatesToSomeValue = new bool[3] { false, false, false };
//
//    /// <summary>
//    /// TRANSFORM (x, y, z): Useful if it is attached to a Camera: This Script can adjust the rotation to some value (e.g.: looking straight at the Horizon).
//    /// </summary>
//    [Tooltip("Value (x, y, z) Useful if it is attached to a Camera: This Script can adjust the rotation to some value (e.g.: looking straight at the Horizon).")]
//    public float[] _adjustCoordenatesToSomeValue = new float[3] { 0.0f, 0.0f, 0.0f };
//

    void Awake()
    {

        // Inicialización del Tranform, caché para OPTIMIZACIÓN:
        //
        this._miTransform = this.gameObject.transform;


        // Inicializar Vector: 'Velocidad Direccionada'
        //
        if ( whichWayToRotate.AroundX == way )
        {
            // Ini
            //
            this._miVector3SpeedDireccionado = Vector3.right * speed; // this._miVector3Right * speed;

        }
        else if ( whichWayToRotate.AroundY == way )
        {
            // Ini
            //
            this._miVector3SpeedDireccionado = Vector3.up * speed;   // this._miVector3Up * speed;

        }
        else if ( whichWayToRotate.AroundZ == way )
        {
            // Ini
            //
            this._miVector3SpeedDireccionado = Vector3.forward * speed;     // this._miVector3Forward * speed;

        }//
        else
        {
            // Caso no contemplado Rotar Horizontal:
            // Ini
            //
            this._miVector3SpeedDireccionado = Vector3.right * speed; // this._miVector3Right * speed;

        }//End else

    }//End Method


//    void Start()
//    {
//
//        // Initialize Start Coordinates, if the user needs it?
//        //
//        this.InitializeCoordenates();
//
//    }//End Method



//    void InitializeCoordenates()
//    {
//
//        // Initialize Start Coordinates, if the user needs it?
//        //
//        int arrayLenght = this._wantToAdjustStartCoordenatesToSomeValue.Length;
//        //
//        // Vector3 temporal para almacenar los resultados porque C# es una !@#$%, MAL DISENO DE UNITY3D usando un STRUCT que es una constante al acceder a TRANSFORM.POSITION...:
//        //
//        Vector3 miVectorTemporal = this.gameObject.transform.rotation;
//        //
//        for (int i = 0; i < arrayLenght; i++)
//        {
//
//            // If it is asked for: Initialize the respective coordinate (x, y, z):
//            //
//            if ( this._wantToAdjustStartCoordenatesToSomeValue[i] )
//            {
//                // Initialize:
//                //
//                if ( i == 0 )
//                {
//                    miVectorTemporal.x = this._adjustCoordenatesToSomeValue[ i ];
//
//                }//End if
//                else if ( i == 1 )
//                {
//                    miVectorTemporal.y = this._adjustCoordenatesToSomeValue[ i ];
//
//                }//End if
//                else if ( i == 2 )
//                {
//                    miVectorTemporal.z = this._adjustCoordenatesToSomeValue[ i ];
//
//                }//End if
//
//            }//End if ( this._wantToAdjustStartCoordenatesToSomeValue[i] )
//
//        }//End for
//
//        // Asignar el valor temporal, para INICIALIZAR REALMENTE:
//        //
//        this.gameObject.transform.Rotate( miVectorTemporal );
//
//    }//End Method


	// LateUpdate is called once per frame
	void LateUpdate ()
    {

		// do the appropriate rotation based on the way state
        //
        this._miTransform.Rotate( this._miVector3SpeedDireccionado * Time.deltaTime );


//        // Not Optimized:
//        // do the appropriate rotation based on the way state
//		switch(way)
//		{
//      
//		case whichWayToRotate.AroundX:
//
//            // No Óptimo:   this._miTransform.Rotate( this._miVector3Right * Time.deltaTime * speed);     //(Vector3.right * Time.deltaTime * speed);
//            // Óptimo:
//            //
//            this._miTransform.Rotate( this._miVector3SpeedDireccionado * Time.deltaTime );
//			break;
//
//		case whichWayToRotate.AroundY:
//
//            // No Óptimo:   this._miTransform.Rotate( this._miVector3Up * Time.deltaTime * speed);        // (Vector3.up * Time.deltaTime * speed);
//            // Óptimo:
//            //
//            this._miTransform.Rotate( this._miVector3SpeedDireccionado * Time.deltaTime );
//			break;
//
//		case whichWayToRotate.AroundZ:
//
//            // No Óptimo:   this._miTransform.Rotate( this._miVector3Forward * Time.deltaTime * speed);        // (Vector3.forward * Time.deltaTime * speed);
//            // Óptimo:
//            //
//            this._miTransform.Rotate( this._miVector3SpeedDireccionado * Time.deltaTime );
//			break;         
//		}//End Switch

	}//End Method
   
}