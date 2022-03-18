using UnityEngine;

namespace RPG.Combat
{
    [CreateAssetMenu(fileName = "Weapon", menuName = "Weapons/Make New Weapon", order = 0)]

    
    public class Weapon : ScriptableObject 
    {
        [SerializeField] AnimatorOverrideController animatorOverride = null;
        [SerializeField] GameObject equippedPrefab = null;
        [SerializeField] float weaponRange = 2.0f;
        [SerializeField] float weaponDamage = 5;
        [SerializeField] bool isRightHanded = true;

        public void Spawn(Transform rightHand, Transform leftHand, Animator animator)
        {
            if (equippedPrefab != null)
            {
                Transform handTransform;
                if (isRightHanded) handTransform = rightHand;
                else handTransform = leftHand;

                Instantiate(equippedPrefab, handTransform);
            }
            if (animatorOverride != null)
            {
                animator.runtimeAnimatorController = animatorOverride;
            }
            
        }

        public float GetRange()
        {
            return weaponRange;
        }
        
        public float GetDamage()
        {
            return weaponDamage;
        }
    }  
} 