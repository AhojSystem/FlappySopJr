using UnityEngine;
using Random = UnityEngine.Random;

public class BarGenerator : MonoBehaviour {
    public GameObject barPrefabRed;
    public GameObject barPrefabBlue;
    public GameObject barPrefabYellow;
    public GameObject barPrefabGreen;
    public GameObject barcol;
    private const float Interval = 0.7f;
    private float _delta;
    private GameObject _bar;
    private GameObject _bar2;
    private GameObject barCol;

    void Update() {
        _delta += Time.deltaTime;
        if (_delta > Interval) {
            _delta = 0;
            if (Random.Range(0, 100) % 2 == 0) {
                _bar = Instantiate(barPrefabRed);
                _bar2 = Instantiate(barPrefabBlue);
            }
            else {
                _bar = Instantiate(barPrefabYellow);
                _bar2 = Instantiate(barPrefabGreen);
            }

            barCol = Instantiate(barcol);

            barCol.transform.position = new Vector3(10, 0, 0);
            _bar.transform.position = new Vector3(10, 4, 0);
            _bar2.transform.position = new Vector3(10, -4, 0);
        }
    }
}