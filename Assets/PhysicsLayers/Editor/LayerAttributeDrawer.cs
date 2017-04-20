﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEditor;

namespace a3geek.PhysicsLayers.Editors
{
    using Attributes;

    [CustomPropertyDrawer(typeof(LayerAttribute))]
    public class LayerAttributeDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if(property.propertyType != SerializedPropertyType.Integer)
            {
                base.OnGUI(position, property, label);
                return;
            }

            var attribute = (LayerAttribute)this.attribute;
            var obj = Selection.activeGameObject;
            if(attribute.Fit2GameObjectLayer == true && obj != null)
            {
                property.intValue = obj.layer;

                var layer = new GUIContent(LayerMask.LayerToName(obj.layer));
                EditorGUI.LabelField(position, label, layer);
                
                return;
            }

            property.intValue = EditorGUI.LayerField(position, label, property.intValue);
        }
    }
}
