using UnityEngine;
using UnityEngine;
using System.Collections;


public class Boss {        
	private int hp = 100;   // 体力
	private int power = 25; // 攻撃力
	private int mp =53;     //魔法


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


	//魔法攻撃用の１０回カウントとmpが5消費出来なくなった場合の処理

	public  void Magic(int mdamage){				
		//Magic関数が一度呼び出されたら初回の処理をする
		this.mp -= mdamage;
		

		for (int cnt = 0; cnt < 10; cnt++) {
			// 尚且つ魔法攻撃用の関数を10回呼び出す

			　　
			if (mp >= 5) {
				// 更にmpが５以上だった場合
				Debug.Log( "魔法攻撃をした。残りMPは"+ mp );

				this.mp -= mdamage;

			} else{
				//mpが5以下
				Debug.Log("MPが足りないため魔法が使えない。");
			}

		}
	
	}

}



public class Test : MonoBehaviour {

		void Start () {
		// Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();

		    // 攻撃用の関数を呼び出す
			lastboss.Attack ();
		    // 防御用の関数を呼び出す
			lastboss.Defence (3);
		　  //魔法攻撃用の関数を呼び出す
			lastboss.Magic (5);

		// 要素数5の配列を初期化する
		int[] hairetu= new int[5];

		// 配列の各要素に値を代入する
		hairetu [0] = 10;
		hairetu [1] = 20;
		hairetu [2] = 30;
		hairetu [3] = 40;
		hairetu [4] = 50;

		// 配列の要素をすべて表示する
		for (int i = 4; i >= 0 ; i--) {
			Debug.Log (hairetu [i]);
		}
	}

		

	// Update is called once per frame
	void Update () {

	}

}
