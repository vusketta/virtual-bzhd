using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementType: MonoBehaviour
{
    public InteractableType elementType;
}

public enum InteractableType
{
    TUMBLER,
    TUMBLER_FLOOR,
    TUMBLER_PROTECT,
    MULT_SWITCH,
    TRIPLE_PHASE_SWITCH,
}
