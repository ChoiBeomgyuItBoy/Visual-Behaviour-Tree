using UnityEditor;
using UnityEngine;

namespace RainbowAssets.BehaviourTree
{
    public abstract class DecoratorNode : Node
    {
        [SerializeField] Node child;

        public override Node Clone()
        {
            DecoratorNode clone = Instantiate(this);

            clone.child = child.Clone();
            
            return clone;
        }

        public Node GetChild()
        {
            return child;
        }

#if UNITY_EDITOR
        public void SetChild(Node child)
        {
            Undo.RecordObject(this, "Child Set");
            this.child = child;
            EditorUtility.SetDirty(this);
        }
#endif
    }
}   