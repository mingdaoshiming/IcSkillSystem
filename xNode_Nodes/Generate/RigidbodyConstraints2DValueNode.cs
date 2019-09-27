using System;
using UnityEngine;
using XNode;

namespace CabinIcarus.IcSkillSystem.Runtime.xNode_Nodes
{
    [CreateNodeMenu("CabinIcarus/Nodes/UnityEngine/Physics2DModule/RigidbodyConstraints2D Value")]
    public partial class RigidbodyConstraints2DValueNode:ValueNode
    {
        [SerializeField]
        private UnityEngine.RigidbodyConstraints2D _value;

        public override Type ValueType { get; } = typeof(UnityEngine.RigidbodyConstraints2D);
        
        protected override object GetOutValue()
        {
            return _value;
        }
    }
}