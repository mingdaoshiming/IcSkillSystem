using System;
using UnityEngine;
using XNode;

namespace CabinIcarus.IcSkillSystem.Runtime.xNode_Nodes
{
    [CreateNodeMenu("CabinIcarus/Nodes/UnityEngine/InputLegacyModule/DeviceOrientation Value")]
    public partial class DeviceOrientationValueNode:ValueNode
    {
        [SerializeField]
        private UnityEngine.DeviceOrientation _value;

        public override Type ValueType { get; } = typeof(UnityEngine.DeviceOrientation);
        
        protected override object GetOutValue()
        {
            return _value;
        }
    }
}