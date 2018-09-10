using System;
using System.Reflection;
using UnityEngine;

public class GG : MonoBehaviour
{
    GUIStyle espColor = new GUIStyle();

    Rect baseRect = new Rect(10, 10, 200, 20);
    Rect windowRect = new Rect(200, 100, 400, 500);

    Boolean g_isGuiActive = false;
    Boolean g_isWeaponStatsActive = false;

    Boolean g_EditAmmo = false;

    CF_231061b977ccfd932241fbf8b5c0456efaab20e9_Corpsefuscated[] weaponClipSize_array;
    CF_231061b977ccfd932241fbf8b5c0456efaab20e9_Corpsefuscated[] weaponAmmoTotal_array;
    CF_231061b977ccfd932241fbf8b5c0456efaab20e9_Corpsefuscated[] weaponAmmo_array;
    CF_0bae97da1ac739402d91dd394edea510fb8a61cf_Corpsefuscated[] weaponShootDelay_array;
    CF_0bae97da1ac739402d91dd394edea510fb8a61cf_Corpsefuscated[] weaponSpread_array;
    CF_0bae97da1ac739402d91dd394edea510fb8a61cf_Corpsefuscated[] weaponSpreadMoving_array;
    CF_0bae97da1ac739402d91dd394edea510fb8a61cf_Corpsefuscated[] weaponFireRate_array;
    CF_0bae97da1ac739402d91dd394edea510fb8a61cf_Corpsefuscated[] weaponKnockbackDistance_array;
    CF_0bae97da1ac739402d91dd394edea510fb8a61cf_Corpsefuscated[] weaponNoiseRange_array;
    CF_0bae97da1ac739402d91dd394edea510fb8a61cf_Corpsefuscated[] weaponDamage_array;

    String tfClipSize0 = "99";
    String tfClipSize1 = "99";
    String tfAmmo0 = "99";
    String tfAmmo1 = "99";
    String tfAmmoTotal0 = "999";
    String tfAmmoTotal1 = "999";
    String tfShootDelay0 = "0.0";
    String tfShootDelay1 = "0.0";
    String tfSpread0 = "0.0";
    String tfSpread1 = "0.0";
    String tfSpreadMoving0 = "0.0";
    String tfSpreadMoving1 = "0.0";
    String tfFireRate0 = "1.0";
    String tfFireRate1 = "1.0";
    String tfKnockbackDistance0 = "10.0";
    String tfKnockbackDistance1 = "10.0";
    String tfNoiseRange0 = "0.0";
    String tfNoiseRange1 = "0.0";
    String tfDamage0 = "1000.0";
    String tfDamage1 = "1000.0";

    public static object GetPropValue(object src, string propName)
    {
        return src.GetType().GetProperty(propName, BindingFlags.Instance | BindingFlags.NonPublic).GetValue(src, null);
    }

    public static object GetFieldValue(object src, string fieldName)
    {
        return src.GetType().GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic).GetValue(src);
    }

    public static void SetFieldValue(object src, string fieldName, object value)
    {
        src.GetType().GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic).SetValue(src, value);
    }

    void Start()
    {
        espColor.normal.textColor = Color.red;

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Delete))
        {
            g_isGuiActive = !g_isGuiActive;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            this.GetLocalPlayer().transform.position += 2f * Camera.main.transform.forward;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.GetLocalPlayer().transform.position += new Vector3(0f, 5f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.GetLocalPlayer().transform.position += new Vector3(0f, -5f, 0f);
        }

        if (g_EditAmmo || g_isWeaponStatsActive)
        {
            CF_8409b6c65878243f11bf2aba2b325885f174c3e9_Corpsefuscated weaponManager = this.GetWeaponManager();
            weaponClipSize_array = (CF_231061b977ccfd932241fbf8b5c0456efaab20e9_Corpsefuscated[])GetFieldValue(weaponManager, "CF_e18febe327a3a1b8722c2702e511ddb793c5bdf9_Corpsefuscated");
            weaponAmmoTotal_array = (CF_231061b977ccfd932241fbf8b5c0456efaab20e9_Corpsefuscated[])GetFieldValue(weaponManager, "CF_e71b775b3824d5c7bdef38e21225e302a577e3af_Corpsefuscated");
            weaponAmmo_array = (CF_231061b977ccfd932241fbf8b5c0456efaab20e9_Corpsefuscated[])GetFieldValue(weaponManager, "CF_3ad265faa5ef11a2d9da61669e2c862cd0a907da_Corpsefuscated");
            weaponShootDelay_array = (CF_0bae97da1ac739402d91dd394edea510fb8a61cf_Corpsefuscated[])GetFieldValue(weaponManager, "CF_e5e24d1a5c153105c81e97cd8390c858ec9ba62b_Corpsefuscated");
            weaponSpread_array = (CF_0bae97da1ac739402d91dd394edea510fb8a61cf_Corpsefuscated[])GetFieldValue(weaponManager, "CF_be5f475f7c7431d1220e26fcdbcf0942e325ca26_Corpsefuscated");
            weaponSpreadMoving_array = (CF_0bae97da1ac739402d91dd394edea510fb8a61cf_Corpsefuscated[])GetFieldValue(weaponManager, "CF_4ff2bfe752c7e141e88caa4ca860acb23827f087_Corpsefuscated");
            weaponFireRate_array = (CF_0bae97da1ac739402d91dd394edea510fb8a61cf_Corpsefuscated[])GetFieldValue(weaponManager, "CF_14befec221b307816983a266174703ba1da2ad1c_Corpsefuscated");
            weaponKnockbackDistance_array = (CF_0bae97da1ac739402d91dd394edea510fb8a61cf_Corpsefuscated[])GetFieldValue(weaponManager, "CF_82b9e17ff71a3223e17d06e1c1aa4fa0d1e1c94b_Corpsefuscated");
            weaponNoiseRange_array = (CF_0bae97da1ac739402d91dd394edea510fb8a61cf_Corpsefuscated[])GetFieldValue(weaponManager, "CF_2d627761605559246f39c0e66863a068a833b8c5_Corpsefuscated");
            weaponDamage_array = (CF_0bae97da1ac739402d91dd394edea510fb8a61cf_Corpsefuscated[])GetFieldValue(weaponManager, "CF_24481d8e1d4b7797515ccda66951c7aafb0c0ae8_Corpsefuscated");
        }

        if (g_EditAmmo)
        {

            weaponClipSize_array[0] = int.Parse(this.tfClipSize0);
            weaponClipSize_array[1] = int.Parse(this.tfClipSize1);
            weaponAmmo_array[0] = int.Parse(this.tfAmmo0);
            weaponAmmo_array[1] = int.Parse(this.tfAmmo1);
            weaponAmmoTotal_array[0] = int.Parse(this.tfAmmoTotal0);
            weaponAmmoTotal_array[1] = int.Parse(this.tfAmmoTotal1);
            weaponShootDelay_array[0] = float.Parse(this.tfShootDelay0);
            weaponShootDelay_array[1] = float.Parse(this.tfShootDelay1);
            weaponSpread_array[0] = float.Parse(this.tfSpread0);
            weaponSpread_array[1] = float.Parse(this.tfSpread1);
            weaponSpreadMoving_array[0] = float.Parse(this.tfSpreadMoving0);
            weaponSpreadMoving_array[1] = float.Parse(this.tfSpreadMoving1);
            weaponFireRate_array[0] = float.Parse(this.tfFireRate0);
            weaponFireRate_array[1] = float.Parse(this.tfFireRate1);
            weaponKnockbackDistance_array[0] = float.Parse(this.tfKnockbackDistance0);
            weaponKnockbackDistance_array[1] = float.Parse(this.tfKnockbackDistance1);
            weaponNoiseRange_array[0] = float.Parse(this.tfNoiseRange0);
            weaponNoiseRange_array[1] = float.Parse(this.tfNoiseRange1);
            weaponDamage_array[0] = float.Parse(this.tfDamage0);
            weaponDamage_array[1] = float.Parse(this.tfDamage1);
        }
    }

    void MainWindow(int windowID)
    {
        GUI.DragWindow(new Rect(0, 0, 10000, 20));

        GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 20, baseRect.width, baseRect.height),
            "ClipSize [0]");
        tfClipSize0 = GUI.TextField(new Rect(baseRect.xMin + 200, baseRect.yMin + 20, 180, baseRect.height),
                tfClipSize0);
        GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 40, baseRect.width, baseRect.height),
            "ClipSize [1]");
        tfClipSize1 = GUI.TextField(new Rect(baseRect.xMin + 200, baseRect.yMin + 40, 180, baseRect.height),
                tfClipSize1);
        GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 60, baseRect.width, baseRect.height),
            "Ammo [0]");
        tfAmmo0 = GUI.TextField(new Rect(baseRect.xMin + 200, baseRect.yMin + 60, 180, baseRect.height),
                tfAmmo0);
        GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 80, baseRect.width, baseRect.height),
            "Ammo [1]");
        tfAmmo1 = GUI.TextField(new Rect(baseRect.xMin + 200, baseRect.yMin + 80, 180, baseRect.height),
                tfAmmo1);
        GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 100, baseRect.width, baseRect.height),
            "AmmoTotal [0]");
        tfAmmoTotal0 = GUI.TextField(new Rect(baseRect.xMin + 200, baseRect.yMin + 100, 180, baseRect.height),
                tfAmmoTotal0);
        GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 120, baseRect.width, baseRect.height),
            "AmmoTotal [1]");
        tfAmmoTotal1 = GUI.TextField(new Rect(baseRect.xMin + 200, baseRect.yMin + 120, 180, baseRect.height),
                tfAmmoTotal1);
        GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 140, baseRect.width, baseRect.height),
            "ShootDelay [0]");
        tfShootDelay0 = GUI.TextField(new Rect(baseRect.xMin + 200, baseRect.yMin + 140, 180, baseRect.height),
                tfShootDelay0);
        GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 160, baseRect.width, baseRect.height),
            "ShootDelay [1]");
        tfShootDelay1 = GUI.TextField(new Rect(baseRect.xMin + 200, baseRect.yMin + 160, 180, baseRect.height),
                tfShootDelay1);
        GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 180, baseRect.width, baseRect.height),
            "Spread [0]");
        tfSpread0 = GUI.TextField(new Rect(baseRect.xMin + 200, baseRect.yMin + 180, 180, baseRect.height),
                tfSpread0);
        GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 200, baseRect.width, baseRect.height),
            "Spread [1]");
        tfSpread1 = GUI.TextField(new Rect(baseRect.xMin + 200, baseRect.yMin + 200, 180, baseRect.height),
                tfSpread1);
        GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 220, baseRect.width, baseRect.height),
            "SpreadMoving [0]");
        tfSpreadMoving0 = GUI.TextField(new Rect(baseRect.xMin + 200, baseRect.yMin + 220, 180, baseRect.height),
                tfSpreadMoving0);
        GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 240, baseRect.width, baseRect.height),
            "SpreadMoving [1]");
        tfSpreadMoving1 = GUI.TextField(new Rect(baseRect.xMin + 200, baseRect.yMin + 240, 180, baseRect.height),
                tfSpreadMoving1);
        GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 260, baseRect.width, baseRect.height),
            "FireRate [0]");
        tfFireRate0 = GUI.TextField(new Rect(baseRect.xMin + 200, baseRect.yMin + 260, 180, baseRect.height),
                tfFireRate0);
        GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 280, baseRect.width, baseRect.height),
            "FireRate [1]");
        tfFireRate1 = GUI.TextField(new Rect(baseRect.xMin + 200, baseRect.yMin + 280, 180, baseRect.height),
                tfFireRate1);

        GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 300, baseRect.width, baseRect.height),
            "KnockbackDistance [0]");
        tfKnockbackDistance0 = GUI.TextField(new Rect(baseRect.xMin + 200, baseRect.yMin + 300, 180, baseRect.height),
                tfKnockbackDistance0);
        GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 320, baseRect.width, baseRect.height),
            "KnockbackDistance [1]");
        tfKnockbackDistance1 = GUI.TextField(new Rect(baseRect.xMin + 200, baseRect.yMin + 320, 180, baseRect.height),
                tfKnockbackDistance1);
        GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 340, baseRect.width, baseRect.height),
            "NoiseRange [0]");
        tfNoiseRange0 = GUI.TextField(new Rect(baseRect.xMin + 200, baseRect.yMin + 340, 180, baseRect.height),
                tfNoiseRange0);
        GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 360, baseRect.width, baseRect.height),
            "NoiseRange [1]");
        tfNoiseRange1 = GUI.TextField(new Rect(baseRect.xMin + 200, baseRect.yMin + 360, 180, baseRect.height),
                tfNoiseRange1);
        GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 380, baseRect.width, baseRect.height),
            "Damage [0]");
        tfDamage0 = GUI.TextField(new Rect(baseRect.xMin + 200, baseRect.yMin + 380, 180, baseRect.height),
                tfDamage0);
        GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 400, baseRect.width, baseRect.height),
            "Damage [1]");
        tfDamage1 = GUI.TextField(new Rect(baseRect.xMin + 200, baseRect.yMin + 400, 180, baseRect.height),
                tfDamage1);

        g_EditAmmo = GUI.Toggle(
            new Rect(baseRect.xMin, baseRect.yMin + 420, baseRect.width, baseRect.height),
            g_EditAmmo, "Edit weapon stats");
        g_isWeaponStatsActive = GUI.Toggle(
            new Rect(baseRect.xMin, baseRect.yMin + 440, baseRect.width, baseRect.height),
            g_isWeaponStatsActive, "Weapon stats");
    }

    void OnGUI()
    {
        if (g_isGuiActive)
        {
            windowRect = GUI.Window(5000, windowRect, MainWindow, "encode");
        }

        if (g_isWeaponStatsActive)
        {
            GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 10, baseRect.width, baseRect.height),
                "ClipSize [0] " + weaponClipSize_array[0].ToString());
            GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 30, baseRect.width, baseRect.height),
                "ClipSize [1] " + weaponClipSize_array[1].ToString());
            GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 50, baseRect.width, baseRect.height),
                "Ammo [0] " + weaponAmmo_array[0].ToString());
            GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 70, baseRect.width, baseRect.height),
                "Ammo [1] " + weaponAmmo_array[1].ToString());
            GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 90, baseRect.width, baseRect.height),
                "AmmoTotal [0] " + weaponAmmoTotal_array[0].ToString());
            GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 110, baseRect.width, baseRect.height),
                "AmmoTotal [1] " + weaponAmmoTotal_array[1].ToString());
            GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 130, baseRect.width, baseRect.height),
                "ShootDelay [0] " + weaponShootDelay_array[0].ToString());
            GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 150, baseRect.width, baseRect.height),
                "ShootDelay [1] " + weaponShootDelay_array[1].ToString());
            GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 170, baseRect.width, baseRect.height),
                "Spread [0] " + weaponSpread_array[0].ToString());
            GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 190, baseRect.width, baseRect.height),
                "Spread [1] " + weaponSpread_array[1].ToString());
            GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 210, baseRect.width, baseRect.height),
                "SpreadMoving [0] " + weaponSpreadMoving_array[0].ToString());
            GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 230, baseRect.width, baseRect.height),
                "SpreadMoving [1] " + weaponSpreadMoving_array[1].ToString());
            GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 250, baseRect.width, baseRect.height),
                "FireRate [0] " + weaponFireRate_array[0].ToString());
            GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 270, baseRect.width, baseRect.height),
                "FireRate [1] " + weaponFireRate_array[1].ToString());

            GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 290, baseRect.width, baseRect.height),
                "KnockbackDistance [0] " + weaponKnockbackDistance_array[0].ToString());
            GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 310, baseRect.width, baseRect.height),
                "KnockbackDistance [1] " + weaponKnockbackDistance_array[1].ToString());
            GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 330, baseRect.width, baseRect.height),
                "NoiseRange [0] " + weaponNoiseRange_array[0].ToString());
            GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 350, baseRect.width, baseRect.height),
                "NoiseRange [1] " + weaponNoiseRange_array[1].ToString());
            GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 370, baseRect.width, baseRect.height),
                "Damage [0] " + weaponDamage_array[0].ToString());
            GUI.Label(new Rect(baseRect.xMin, baseRect.yMin + 390, baseRect.width, baseRect.height),
                "Damage [1] " + weaponDamage_array[1].ToString());
        }

    }

    GameObject GetLocalPlayer()
    {
        return (GameObject)GetFieldValue(
            CF_7cd5a34bf81ef76a46030901e98949ef7a60c6cb_Corpsefuscated.playerCameraRig,
            "CF_fae6eb97cf5288466a729e5e76f7605893b85e02_Corpsefuscated");
    }

    CF_8409b6c65878243f11bf2aba2b325885f174c3e9_Corpsefuscated GetWeaponManager()
    {
        return CF_7cd5a34bf81ef76a46030901e98949ef7a60c6cb_Corpsefuscated.CF_2c24f0bf61be976e9b5185f2a8195015b5661e89_Corpsefuscated;
    }
}