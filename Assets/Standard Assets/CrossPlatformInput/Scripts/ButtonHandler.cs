using System;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
    public class ButtonHandler : MonoBehaviour
    {

        public string Name;

//        void OnEnable()
//        {
//
//        }

        void OnDisable()
        {
            // (2018/08/01): Solución al BUG: "Al hacer un DISABLE y RE-ENABLE del GameObject principal-Padre: Se queda estancado el PORTERO o PLAYER en su posición anterior de cuando desapareció".
            // ..Con esto se desea deshabilitar la acción del botón toatalmente, al hacer desaparecer el mismo.
            //
            CrossPlatformInputManager.SetAxisZero(Name);

        }
        public void SetDownState()
        {
            CrossPlatformInputManager.SetButtonDown(Name);
        }


        public void SetUpState()
        {
            CrossPlatformInputManager.SetButtonUp(Name);
        }


        public void SetAxisPositiveState()
        {
            CrossPlatformInputManager.SetAxisPositive(Name);
        }


        public void SetAxisNeutralState()
        {
            CrossPlatformInputManager.SetAxisZero(Name);
        }


        public void SetAxisNegativeState()
        {
            CrossPlatformInputManager.SetAxisNegative(Name);
        }

//        public void Update()
//        {
//
//        }
    }
}
