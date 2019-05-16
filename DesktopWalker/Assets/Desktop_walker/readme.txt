Unity上でキャラクターを動かすサンプルです。WallpaperEngineがあればデスクトップ画面にキャラクターを表示することができます。マウスに視線が追従し、クリックした場所にキャラクターが移動します。

～規約
・本製品を使って発生した問題に対しては製作者は一切の責任を負いません。
・アニメーションファイルはユニティちゃんライセンス© Unity Technologies Japan/UCL の元再配布しています。
許可事項
・改変・解析
禁止事項
・迷惑行為等

【導入手順】
①任意のシーン上に"systemobject"をドロップする。
②"Plane"のPositionとScaleを床に合わせる(Rotationはいじってはいけない)。
③キャラクターのモデルデータをシーンに配置する。
④キャラクターに"avatarAnimator"と"AvatarControll"と"IKLookat"をドロップする。
⑤"AvatarControll"と"IKLookat"のそれぞれの"LookAtObj"に"systemobject/lookat"を、"WalkAtObj"に"systemobject/walkat"をドロップする。

⑥File/Build&Runからexeファイルをエクスポートする。
⑦WallpaperEngineにexeファイルをドロップする。


【項目説明】
LookAtObj : 任意のゲームオブジェクトにドロップしてください。マウスに追従します。
 LookDepth : キャラクターの目線がカメラから何メートルの位置に向くか指定します。(AvaterObjがnullの時)
 AvatarObj : ここにキャラクターを指定すると、LookDepthの値がキャラクター基準になります。
WalkAtObj : 任意のゲームオブジェクトにドロップしてください。マウスクリックで移動します。
 Plane : 床となるplaneオブジェクトを指定してください。positionとscaleは計算しますが、rotationが考慮しないので注意してください。

IKLookAt : キャラクターにドロップしてください。目線の制御をします。
 LookAtObj : LookAtObjをドロップしたオブジェクトを指定してください。アバターの視線が追従します。
 LookAtWeight : どれくらいの鈍さで視線を向けるか。
 BodyWeight : どれくらい体を動かすか。
 HeadWeight : どれくらい頭を動かすか。
 EyesWeight : どれくらい目を動かすか。
 ClampWeight : 動きの最大値。
AvatarControll
 LookAtObj : LookAtObjをドロップしたオブジェクトを指定してください。アバターの視線が追従します。
 WalkAtObj : WalkAtObjをドロップしたオブジェクトを指定してください。その位置にアバターが移動します。
 MinTime : ランダムなアニメーションが発生する周期の最小値です。
 MaxTime : ランダムなアニメーションが発生する周期の最大値です。
 WalkDist : WalkAtとの距離がこの値以上だと歩き始めます。
 WalkSpeed : 歩く速度です。

avatarAnimator : アバターのアニメーターにドロップしてください。
Idle0が通常アニメーション、Idle1~4がランダムに発生するアニメーション。
Walkが歩行アニメーションです。


* by,HhotateA
* Released under the MIT license
* Twitter :@HHOTATEA_VRC
*
* Date: 2018-04-25 開始