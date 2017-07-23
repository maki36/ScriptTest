using UnityEngine;
using UnityEngine;
using System.Collections;

//public class Test : MonoBehaviour {

public class Boss {        
	private int hp = 100;   // 体力
	private int power = 25; // 攻撃力
	private int mp =53;     //魔法
	//private int cut =10;
	//private int mainas=1;

	// 攻撃用の関数
	public void Attack() { 
		Debug.Log( this.power + "のダメージを与えた" );
	}

	// 防御用の関数
	public  void Defence(int damage) { 
		Debug.Log( damage + "のダメージを受けた" );
		// 残りhpを減らす
		this.hp -= damage;
	}

	public void Magic(int mdamage){

		if (mp >= 5) {
			// mpが５以上だった場合
			Debug.Log( "魔法攻撃をした。残りMPは"+ mp );
			this.mp -= mdamage;
			//this.cut -= mainas;
		} else {
			// mpが５以下
			Debug.Log("MPが足りないため魔法が使えない。");
		}

	}
}

public class Test : MonoBehaviour {

		void Start () {
		// Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();
		for (int cnt = 0; cnt < 11; cnt++) {
			
			// 攻撃用の関数を呼び出す
			lastboss.Attack ();
			// 防御用の関数を呼び出す
			lastboss.Defence (3);
			// 魔法攻撃用の関数を呼び出す
			lastboss.Magic (5);
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
