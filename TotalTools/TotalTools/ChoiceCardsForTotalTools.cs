using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using ChoiceCardsForTotalTools.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;


namespace ChoiceCardsForTotalTools
{
    // These are the mods required for our mod to work
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    // Declares our mod to Bepin
    [BepInPlugin(ModId, ModName, Version)]
    // The game our mod is associated with
    [BepInProcess("Rounds.exe")]
    public class ChoiceCardsForTotalTools : BaseUnityPlugin
    {
        public static ChoiceCardsForTotalTools instance { get; private set; }//added in step "Add a Reference to your Mod’s core class". Should there be a ; ? #question
        private const string ModId = "com.Waatai.rounds.CCFTT";// ref code uses .Mod and the tutorial changes to .rounds , which should it be? what would it even mean in this game? #question
        private const string ModName = "Choice Cards For Total Tools";
        public const string Version = "1.1.2"; // What version are we on (major.minor.patch)?
        public const string ModInitials = "CCFTT";

        void Awake()
        {
            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }
        void Start()
        {
            instance = this;//added in step "Add a Reference to your Mod’s core class"
            CustomCard.BuildCard<ImBack>();
            CustomCard.BuildCard<RealFastPaul>();
        }
    }
}
