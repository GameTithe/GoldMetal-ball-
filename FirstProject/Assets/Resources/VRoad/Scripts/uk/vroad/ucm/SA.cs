using uk.vroad.api.str;

namespace uk.vroad.ucm
{
    public static class SA
    {
        public const string COPY_TO_CLIPBOARD = "> Ctrl-C [Contents Copied to Clipboard]";

        public const string NO_BOT_PARENTS =
            "Did not find parent objects for peds, cars, coaches, trucks, taxis, buses";

        public const string UNEXPECTED_PKG_LOC = "VRoad package is not in expected location: ";

        // --------- Strings requiring translations above this line -------------------------


        public const string SONY = "sony"; // to recognize a PS4-layout gamepad vs XBox layout
        public const string MOUSE_X = "Mouse X";
        public const string MOUSE_Y = "Mouse Y";

        public const string Anim_isIdleActive = "isIdleActive";
        public const string Anim_isWalking = "isWalking";

        public const string ASSETS_DIR = "Assets"; // *** No trailing slash
        public const string EXPECTED_PKG_LOC = "Assets/VRoad";
        public const string MESH_GEN_DIR = "Models/MapMeshes";
        public const string PREFAB_GEN_DIR = "Prefabs/Maps";
        public const string SUFFIX_ASSET = ".asset";
        public const string SUFFIX_PREFAB = ".prefab";
        public const string SUFFIX_MAT = ".mat";
        public const string SUFFIX_TEX = "_tex.asset";
        public const string TERRAIN = "UnityTerrain";
        public const string PREFAB_MESH_NAME_FMT = "%s_%04d";
        public const string UNITY_RUNNER = "UnityRunner";
        public const string DOT_BINX = ".bin";

        public const string LANE_TEX_BLANK = "Blank";
        public const string LANE_TEX_EDGE = "Edge";
        public const string LANE_TEX_FLOW_WITH = "Flow With";
        public const string LANE_TEX_FLOW_AGAINST = "Flow Against";
        public const string LANE_TEX_UNSUITABLE = "Unsuitable texture for half-lane: ";

        public const string LANE_TEX_WARNING = "Textures for lanes must be non-null, 256x512, " +
                                               "and Read/Write Enabled in Unity Inspector";

        public static readonly string[] MARKING_LABEL = new string[]
        {
            "NoMarking", // contains no underscore
            "RoadEdge_RoadEdge",    // The underscore is important, it marks this as having a texture that must be saved
            "RoadEdge_LaneWith",    // contains underscore (see above)
            "RoadEdge_LaneAgainst", // contains underscore (see above)
            "LaneWith_RoadEdge",    // contains underscore (see above)
            "LaneWith_LaneWith",    // contains underscore (see above)
            "LaneWith_LaneAgainst", // contains underscore (see above)
            "LaneAgainst_RoadEdge", // contains underscore (see above)
            "LaneAgainst_LaneWith", // contains underscore (see above)
            "BusesTaxis", // contains no underscore
            "NoVehicles", // contains no underscore
            "NoTrucks",   // contains no underscore
        };
    
#if UNITY_EDITOR_WIN
        public const string ARCH_DIR = SF.ARCH_WIN64;
        public const string DOT_BIN = ".exe";
#endif
    }
}