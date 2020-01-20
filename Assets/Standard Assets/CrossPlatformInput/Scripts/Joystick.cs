using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UnityStandardAssets.CrossPlatformInput
{
	public class Joystick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
	{
		public enum AxisOption
		{
			// Options for which axes to use
			Both, // Use both
			OnlyHorizontal, // Only horizontal
			OnlyVertical // Only vertical
		}

		public int MovementRange = 100;
		public AxisOption axesToUse = AxisOption.Both; // The options for the axes that the still will use
		public string horizontalAxisName = "Horizontal"; // The name given to the horizontal axis for the cross platform input
		public string verticalAxisName = "Vertical"; // The name given to the vertical axis for the cross platform input


        /// <summary>
        /// The m transform de this GameObject in space.
        /// </summary>
        private Transform m_Transform;

		Vector3 m_StartPos;


        /// <summary>
        /// The m new position.
        /// </summary>
        private Vector3 m_newPosition = new Vector3(0.0f, 0.0f, 0.0f);

        /// <summary>
        /// Auxiliar Vector.
        /// </summary>
        private Vector3 m_auxiliarVector = new Vector3(0.0f, 0.0f, 0.0f);


        /// <summary>
        /// The mi vector3 zero.
        /// </summary>
        public static readonly Vector3 m_Vector3Zero = Vector3.zero;

//        /// <summary>
//        /// Posicion Inicial del JOYSTICK, la cual se mantendrá no importando si se hace un ENABLE y DISABLE del Joystick:
//          /// OJO: No funciona. Borrar.
//        /// </summary>
//        private Vector3 m_Constant_StartPos;

		bool m_UseX; // Toggle for using the x axis
		bool m_UseY; // Toggle for using the Y axis
		CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis; // Reference to the joystick in the cross platform input
		CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis; // Reference to the joystick in the cross platform input

            
		void OnEnable()
		{
            // Antes era (y esta bien así):
            //
            CreateVirtualAxes();

            // Hay un BUG: "Al hacer un DISABLE y RE-ENABLE del GameObject principal-Padre: Se queda estancado en su posición anterior de cuando desapareció".
            // ..Con esto se desea hacerlo volver a su punto inicial, o zona de 'valor = 0' (del Joystcik).
            // ...Esto ocurre porque el sistema NO guarda bien la posición INICIAL del JOYSTICK en la variable/Atributo:    m_StartPos,   sino que la borra (al hacer un ""OnDisable"") y luego la vuelve (0,0) cuando hacemos el 'OnEnable()'
            // La SOLUCION: Ver el ""OnDisable()"", más abajo.
		}

        void Start()
        {
            // Caché de Transform:
            //
            this.m_Transform = this.gameObject.transform;

            m_StartPos = this.m_Transform.position; // transform.position;
        }

		void UpdateVirtualAxes(Vector3 value)
		{
			var delta = m_StartPos - value;
			delta.y = -delta.y;
			delta /= MovementRange;
			if (m_UseX)
			{
				m_HorizontalVirtualAxis.Update(-delta.x);
			}

			if (m_UseY)
			{
				m_VerticalVirtualAxis.Update(delta.y);
			}
		}

		void CreateVirtualAxes()
		{
			// set axes to use
			m_UseX = (axesToUse == AxisOption.Both || axesToUse == AxisOption.OnlyHorizontal);
			m_UseY = (axesToUse == AxisOption.Both || axesToUse == AxisOption.OnlyVertical);

			// create new axes based on axes to use
			if (m_UseX)
			{
				m_HorizontalVirtualAxis = new CrossPlatformInputManager.VirtualAxis(horizontalAxisName);
				CrossPlatformInputManager.RegisterVirtualAxis(m_HorizontalVirtualAxis);
			}
			if (m_UseY)
			{
				m_VerticalVirtualAxis = new CrossPlatformInputManager.VirtualAxis(verticalAxisName);
				CrossPlatformInputManager.RegisterVirtualAxis(m_VerticalVirtualAxis);
			}
		}


		public void OnDrag(PointerEventData data)
		{
            // Vector3 newPos = miVector3Zero;      // Optimización, quitar esto: Vector3.zero;
            //
            this.m_newPosition = m_Vector3Zero;

			if (m_UseX)
			{
				int delta = (int)(data.position.x - m_StartPos.x);
				delta = Mathf.Clamp(delta, - MovementRange, MovementRange);
                //
				// newPos.x = delta;
                //
                this.m_newPosition.x = delta;
			}

			if (m_UseY)
			{
				int delta = (int)(data.position.y - m_StartPos.y);
				delta = Mathf.Clamp(delta, -MovementRange, MovementRange);
                //
				// newPos.y = delta;
                //
                this.m_newPosition.y = delta;
			}
            this.m_auxiliarVector.Set (m_StartPos.x + this.m_newPosition.x, m_StartPos.y + this.m_newPosition.y, m_StartPos.z + this.m_newPosition.z);
            //
            // transform.position = this.m_auxiliarVector;  // new Vector3(m_StartPos.x + this.m_newPosition.x, m_StartPos.y + this.m_newPosition.y, m_StartPos.z + this.m_newPosition.z);
            // Optimización de lo de arriba:
            //
            this.m_Transform.position = this.m_auxiliarVector;  // new Vector3(m_StartPos.x + this.m_newPosition.x, m_StartPos.y + this.m_newPosition.y, m_StartPos.z + this.m_newPosition.z);
            //
            UpdateVirtualAxes( this.m_Transform.position /* transform.position */);
		}

        /// <summary>
        /// Raises the pointer up event. It makes the Joystick to go to it's initial Position alone, fast.
        /// </summary>
        /// <param name="data">Data.</param>
		public void OnPointerUp(PointerEventData data)
		{
			// transform.position = m_StartPos;
            // Optimización:
            //
            this.m_Transform.position = m_StartPos;

			UpdateVirtualAxes(m_StartPos);
		}


		public void OnPointerDown(PointerEventData data) { }

        
		void OnDisable()
		{
            // (2018/06/03): Solución al BUG: "Al hacer un DISABLE y RE-ENABLE del GameObject principal-Padre: Se queda estancado en su posición anterior de cuando desapareció".
            // ..Con esto se desea hacerlo volver a su punto inicial, o zona de 'valor = 0' (del Joystcik).
            // Hacer que el Joystick vuelva a su posicion original:
            //
            OnPointerUp(null);

			// remove the joysticks from the cross platform input
			if (m_UseX)
			{
				m_HorizontalVirtualAxis.Remove();
			}
			if (m_UseY)
			{
				m_VerticalVirtualAxis.Remove();
			}
		}
	}
}