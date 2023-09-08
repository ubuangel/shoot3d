
using UnityEngine;

public class balaController : MonoBehaviour
{
    // Start is called before the first frame update
  //detectar colisiones y actualziar puntuacion
  //parte 7 video https://www.youtube.com/watch?v=AXUYgQi2EHQ

  
//asignar objeto gamecontroller a la bala
  //otra forma es que  instanciamos la bala  desde el codigo buscar el objeto que se llama  gamecontroller y asignarcelo es decir hacelo desde el codigo en el  momento que se crea la bala como tal, en ese instanse siet ,cuando instanciamos la bala en ese momento abria que asignarle ese game controler ,pero una forma que se emplea aca es usar la bla de la ese a y meterle el script  
  
    public GameController gameController;

    void OnCollisionEnter(Collision obj){
            gameController.targetHit(obj.gameObject);
    }

}
