using UnityEngine;

public class EscapeGameManager : MonoBehaviour
{
    // シングルトンインスタンス
    public static EscapeGameManager instance;

    // ゲーム進行状態
    public bool isGameCompleted = false;  // ゲームがクリアされたかどうか
    public int solvedPuzzles = 0;         // 解いたパズルの数
    public int totalPuzzles = 5;          // 総パズル数 (例)

    private void Awake()
    {
        // シングルトンのセットアップ
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // パズルを解いたときに呼ばれるメソッド
    public void PuzzleSolved()
    {
        solvedPuzzles++;
        Debug.Log("Puzzles solved: " + solvedPuzzles);

        if (solvedPuzzles >= totalPuzzles)
        {
            CompleteGame();  // すべてのパズルを解いたらゲームクリア
        }
    }

    // ゲームをクリアしたときに呼ばれるメソッド
    void CompleteGame()
    {
        isGameCompleted = true;
        Debug.Log("Game Completed!");
        // クリア画面の表示や次の処理を追加
    }

    // ゲーム進行状況を保存するメソッド
    public void SaveProgress()
    {
        PlayerPrefs.SetInt("SolvedPuzzles", solvedPuzzles);
        PlayerPrefs.Save();
        Debug.Log("Game progress saved.");
    }

    // ゲーム進行状況を読み込むメソッド
    public void LoadProgress()
    {
        if (PlayerPrefs.HasKey("SolvedPuzzles"))
        {
            solvedPuzzles = PlayerPrefs.GetInt("SolvedPuzzles");
            Debug.Log("Game progress loaded. Solved puzzles: " + solvedPuzzles);
        }
    }

    // 謎解きゲームのリスタート（進行状況リセット）メソッド
    public void RestartGame()
    {
        solvedPuzzles = 0;
        isGameCompleted = false;
        Debug.Log("Game restarted.");
        // 必要に応じてシーンをリロード
    }
}
