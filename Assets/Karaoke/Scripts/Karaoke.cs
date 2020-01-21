using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

namespace Hammerplay.Utils.Karaoke
{
	public class Karaoke : MonoBehaviour
    {

        /// <summary>
        /// Frase Actual de la Canción del Karaoke: Va de 0 (primera) a 2 (Tercera) a 'n-1'.
        /// </summary>
        [HideInInspector]
        public int _miParteDeLaCancionActual = -1;

        /// <summary>
        /// Bandera: Permite saber si acaba de CAMBIAR DE FRASE, y no se ha encendido la pregunta de Trivia a'un.del Karaoke.
        /// </summary>
        public bool _estaPendienteUnCambioDeFraseOTrivia = false;


        /// <summary>
        /// Frase que, al aparecer en la Trivia: Hará que salgan llas Imáges-Trivia, parte 1.
        /// </summary>
        const string _FRASE_1_TRIVIA_KARAOKE = "Los po";

        /// <summary>
        /// Bandera: Permite controlar si ya se consiguió la FRASE en las líneas del Karaoke.
        /// </summary>
        public bool _yaConsiguioFrase1 = false;

        /// <summary>
        /// Frase que, al aparecer en la Trivia: Hará que salgan llas Imáges-Trivia, parte 2.
        /// </summary>
        const string _FRASE_2_TRIVIA_KARAOKE = "La ga";

        /// <summary>
        /// Bandera: Permite controlar si ya se consiguió la FRASE en las líneas del Karaoke.
        /// </summary>
        public bool _yaConsiguioFrase2 = false;


        /// <summary>
        /// Frase que, al aparecer en la Trivia: Hará que salgan llas Imáges-Trivia, parte 3.
        /// </summary>
        const string _FRASE_3_TRIVIA_KARAOKE = "Bajo sus";

        /// <summary>
        /// Bandera: Permite controlar si ya se consiguió la FRASE en las líneas del Karaoke.
        /// </summary>
        public bool _yaConsiguioFrase3 = false;


        [SerializeField]
		private TextAsset subtitleFile;

		[SerializeField]
		private bool playOnAwake;

		[SerializeField]
		private string highlightStartTag = "<Color=Red>";

		[SerializeField]
		private string highlightEndTag = "</Color>";

		public Text text;

		private UnityEvent onComplete;

		private void Awake()
        {			

			if (text == null)
            {

                this.text = GetComponent<Text>();

                if (text == null)
                {
                    // No solution, display error:
                    //
                    Debug.LogError("Can't find Text component in Gameobject, Karaoke needs Text Component");
                    this.enabled = false;
                }                

			}//End if
		}

		private void Start()
        {
			if (playOnAwake)
				StartSubtitle();
		}

		/// <summary>
		/// Starts the karaoke subtitles.
		/// </summary>
		public void StartSubtitle()
        {
			StartSubtitle(null);
		}

		/// <summary>
		/// Starts the karaoke subtitles.
		/// </summary>
		/// <param name="onComplete"></param>
		public void StartSubtitle(UnityEvent onComplete)
        {
			if (subtitleFile == null)
            {
				Debug.LogError("Need subtitle file, use a SSA/ASS file in .txt format");
				return;
			}

			StartCoroutine(Begin());
			this.onComplete = onComplete;
		}

		private IEnumerator Begin()
        {
			var parser = new ASSParser(subtitleFile);
			var startTime = Time.time;

			while (true)
            {
				var elasped = Time.time - startTime;

				int substringIndex = 0;
				var subtitle = parser.GetForTime(elasped, out substringIndex);

				if (subtitle != null)
                {
					string modifiedString = subtitle.Text;

                    // This part adds the Highlight to the Karaoke Lyrics:
                    // End (</Color>) Tag:
                    //
                    modifiedString = modifiedString.Insert(substringIndex, highlightEndTag);
                    //
                    // Add the Start Color TAG = <Color=Red>
                    //
                    modifiedString = modifiedString.Insert(0, highlightStartTag);
                    //
                    // Add the Complete String to the UI-Text Component (we could use a TextMeshPro UI-Text here):
                    //
					text.text = modifiedString;
                    //
                    // AlMartson (i.e.: Alejandro Almarza): I will add my two cents here:
                    // CHECK whether we are passing throught the Start of An Animated-Important Phrase:
                    //
                    //int index = -1;
                    //index = modifiedString.IndexOf(@_FRASE_2_TRIVIA_KARAOKE /*@_FRASE_1_TRIVIA_KARAOKE*/ );
                    ////
                    //if (index >= 0)       // int index = str.IndexOf(@"\");
                    //{
                    //    Debug.LogWarning("\n\n" + _FRASE_1_TRIVIA_KARAOKE);

                    //}//End if


                    BuscarFraseParaTrivia(modifiedString);

                }
				else    // We are done. End of Song / Video.
                {

					if (onComplete != null)
						onComplete.Invoke();

					yield break;
				}

				yield return null;
			}//ENd while
		}//End Method



        /// <summary>
        /// 
        /// </summary>
        /// <param name="lineaDeTextoKaraoke"></param>
        public void BuscarFraseParaTrivia(string lineaDeTextoKaraoke)
        {

            if (! this._estaPendienteUnCambioDeFraseOTrivia)
            {

                if ((!_yaConsiguioFrase1) && (!_yaConsiguioFrase2) && (!_yaConsiguioFrase3))
                {

                    // Buscar FRASE 1:
                    //
                    if (lineaDeTextoKaraoke.IndexOf(@_FRASE_1_TRIVIA_KARAOKE) > 0)
                    {

                        Debug.LogWarning(_FRASE_1_TRIVIA_KARAOKE);
                        //
                        // Setea la bandera de ENCONTRADO
                        //
                        this._yaConsiguioFrase1 = true;
                        //
                        // Marcar Inicio de FASE 1 FRASE 1 de Trivia:
                        //
                        this._miParteDeLaCancionActual = 0;
                        //
                        // Pendiente un Cambio de FRASE
                        //
                        this._estaPendienteUnCambioDeFraseOTrivia = true;

                    }//End if (

                }//End if ( (!_yaConsiguioFrase1...
                else if ((_yaConsiguioFrase1) && (!_yaConsiguioFrase2) && (!_yaConsiguioFrase3))
                {

                    // Buscar FRASE 2:
                    //
                    if (lineaDeTextoKaraoke.IndexOf(@_FRASE_2_TRIVIA_KARAOKE) > 0)
                    {

                        Debug.LogWarning(_FRASE_2_TRIVIA_KARAOKE);
                        //
                        // Setea la bandera de ENCONTRADO
                        //
                        this._yaConsiguioFrase2 = true;
                        //
                        // Marcar Inicio de FASE 2 FRASE 2 de Trivia:
                        //
                        this._miParteDeLaCancionActual = 1;
                        //
                        // Pendiente un Cambio de FRASE
                        //
                        this._estaPendienteUnCambioDeFraseOTrivia = true;

                    }//End if (

                }//End if ( (!_yaConsiguioFrase1...
                //
                else if ((_yaConsiguioFrase1) && (_yaConsiguioFrase2) && (!_yaConsiguioFrase3))
                {

                    // Buscar FRASE 2:
                    //
                    if (lineaDeTextoKaraoke.IndexOf(@_FRASE_3_TRIVIA_KARAOKE) > 0)
                    {

                        Debug.LogWarning(_FRASE_3_TRIVIA_KARAOKE);
                        //
                        // Setea la bandera de ENCONTRADO
                        //
                        this._yaConsiguioFrase3 = true;
                        //
                        // Marcar Inicio de FASE 3 FRASE 3 de Trivia:
                        //
                        this._miParteDeLaCancionActual = 2;
                        //
                        // Pendiente un Cambio de FRASE
                        //
                        this._estaPendienteUnCambioDeFraseOTrivia = true;

                    }//End if (

                }//End if ( (!_yaConsiguioFrase1...

            }//End if

        }//End Method


    }
}
