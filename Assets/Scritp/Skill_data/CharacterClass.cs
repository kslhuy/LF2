using UnityEngine;
using UnityEngine.Serialization;


    /// <summary>
    /// Data representation of a Character, containing such things as its starting HP and Mana, and what attacks it can do.
    /// </summary>
[CreateAssetMenu(menuName = "GameData/CharacterClass", order = 1)]
public class CharacterClass : ScriptableObject
    {
        [Tooltip("which character this data represents")]
        public CharacterTypeEnum CharacterType;

        public ActionType DefRightAttack;

        
        public ActionType DefLeftAttack;

        
        public ActionType DefUpAttack;

        public ActionType DefDownAttack;

        public ActionType DefRightJump;

        public ActionType DefLeftJump;

        public ActionType DefUpJump;

        public ActionType DefDownJump;

        public IntVariable BaseHP;

        public int BaseMana;

        [Tooltip("Base movement speed of this character class (in meters/sec)")]
        public float Speed;

        [Tooltip("Set to true if this represents an NPC, as opposed to a player.")]
        public bool IsNpc;

        [Tooltip("For NPCs, this will be used as the aggro radius at which enemies wake up and attack the player")]
        public float DetectRange;

        [Tooltip("For players, this is the displayed \"class name\". (Not used for monsters)")]
        public string DisplayedName;

        

    }
