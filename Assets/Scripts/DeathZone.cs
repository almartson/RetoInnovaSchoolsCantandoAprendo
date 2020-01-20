using UnityEngine;

public class DeathZone : MonoBehaviour
{

////	/// <summary>
////	/// Objeto Balon del Juego.
////	/// </summary>
////	[Tooltip("Objeto Balon del Juego.")]
////	public LineaDeGol _miScriptLineaDeGol;


////	void Start() 
////	{
////
////	}

//	void OnTriggerEnter(Collider other)
//	{

//        if ( /*(GameManager.gm != null) &&*/ (GameManager.gm._gameStateWhenPlaying == GameManager._GAME_STATES_WHEN_PLAYING.Chutando) )
//        {

//            // Si el Balón atraviesa la DEATH ZONE: Marcar que NO FUE GOL.
//            //
//            //   OPTIMIZACIÓN: Quitar la validación del TAG, ya que en la ""COLLISION MATRIX"" se especificó 
//            //...que SÓLO EL ""LAYER"" del Balón colisionaría contra el ""LAYER"" 
//            //
////            if (other.gameObject.tag == "Balon" /*other.gameObject.tag == "Balon"*/)
////            {

//                // Aca poner una transicion: Va:
//                // 1- ABUCHEO (NO-Felicidades) por el NOOOO-GOL! (Game Juice, Animacion)
//                // 2- Fade-Out para establecer la pelota en su nueva localizacion (Game Juice, Animacion).
//                // 3- (Ademas se anota el NO-GOL en la GUI). 
//                //   Luego: (Game Juice, Animacion: Para decir que: "<Silbatazo>... + Puedes disparar el balon", cada 5 segundos, para que sepa que le toca).
//                //
//                // Mientras tanto: 
//                // 1- Restablecer Velocidad a cero:
//                //
//                ///OJO, DESCOMENTAR PARA IMPLEMENTAR UN RESPAWN DESPUES:    this._balonRigidbody.velocity = Vector3.zero;

//                // 2- Restablece Posicion:
//                //
//                ///OJO, DESCOMENTAR PARA IMPLEMENTAR UN RESPAWN DESPUES:    this._balon.transform.position = this._puntoDePenalty.transform.position;
//                //
//                GameManager.gm._faltaTomarNotaDelGolReciente = true;
//                //
//                // NO es un GOOOL!:
//                //
//                GameManager.gm._gameStateWhenPlaying = GameManager._GAME_STATES_WHEN_PLAYING.CelebracionNoEsGol;

//                ///Destroy(other.gameObject);

////            }//End if (other.gameObject.tag == "Balon" /*other.gameObject.tag == "Balon"*/)

//		}//end if ( GameManager.gm._gameStateWhenPlaying != GameManager._GAME_STATES_WHEN_PLAYING.Chutando )
//	}
}
