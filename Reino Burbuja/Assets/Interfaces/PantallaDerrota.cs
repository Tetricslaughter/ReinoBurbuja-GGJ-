using UnityEngine;
using UnityEngine.SceneManagement;

public class PantallaDerrota : MonoBehaviour
{
    public GameObject ObjetoMenuPausa;
    public bool Pausa = false;
    public bool bandera = true;
    public bool derrota=false;
    //public GameObject GrupoSalir;
    //public GameObject GrupoInformacion;
    //public GameObject GrupoOpciones;

    // Start is called before the first frame update
    void Start()
    {
        // Asegurarse de que el menú de pausa esté inactivo al inicio
        ObjetoMenuPausa.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Cambiar "input" por "Input"
        if (derrota && bandera)
        {
            bandera = false;
            if (Pausa == false)
            {
                ObjetoMenuPausa.SetActive(true);
                Pausa = true;

                Time.timeScale = 0;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Resumir();
            }
        }
    }

    public void Resumir()
    {
        ObjetoMenuPausa.SetActive(false);
        //GrupoSalir.SetActive(false);
        //GrupoInformacion.SetActive(false);
        //GrupoOpciones.SetActive(false);
        Pausa = false;

        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void IrAlMenu(int NombreMenu)
    {
        // Restablecer el tiempo antes de cambiar de escena
        Time.timeScale = 1;
        SceneManager.LoadScene(NombreMenu);
    }

    public void CambiarDerrota(bool condicion)
    {
        derrota = condicion;
    }
}
