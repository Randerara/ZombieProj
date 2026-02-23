using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class GameManager : MonoBehaviour
{
    
    
    public GameObject selectedZombies;
    public GameObject[] zombies;
    public Vector3 selectedSize;
    public Vector3 pushForce;
    private InputAction left, right, jump;
    private int selectedIndex = 0;
    public TMP_Text timerText;
    public TMP_Text scoreText;
    private float score = 0;
    private float time = 0;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       SelectZombie(0);
       left = InputSystem.actions.FindAction("Old Zomb");
       right = InputSystem.actions.FindAction("New Zomb");
       jump = InputSystem.actions.FindAction("Jump");
    }

    void SelectZombie(int index)
    {
        if (selectedZombies != null)
            selectedZombies.transform.localScale = Vector3.one; 
        selectedZombies = zombies[index];
        selectedZombies.transform.localScale = selectedSize;
        Debug.Log("Selected:  " + selectedZombies.name);
    }
    
    // Update is called once per frame
    void Update()
    {
        if (left.WasPressedThisFrame())
        {
            selectedIndex--;
            if(selectedIndex < 0)
                selectedIndex = zombies.Length - 1;
            SelectZombie(selectedIndex);
        }   
        if (right.WasPressedThisFrame())
        {
            selectedIndex++;
            if(selectedIndex >= zombies.Length)
                selectedIndex = 0;
            SelectZombie(selectedIndex);
        }

        if (jump.WasPressedThisFrame())
        {
            Rigidbody rb = selectedZombies.GetComponent<Rigidbody>();
            rb.AddForce(pushForce);
            Debug.Log("Jump");
        }

        time += Time.deltaTime;
        timerText.text = "Time:  " + time.ToString("F1") + " seconds";
    }
}
