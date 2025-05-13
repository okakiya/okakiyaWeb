# MOD作成

## スクリプト

今は未だ書き殴りのことご了承ください。
C#の書き方はある程度わかっているものとする （okakiya自身もわかっていないため）

### おおまかな流れ

1. Playgroundにノードのcsファイルを配置して試す
2. Unity Warudo SDKでにノードとプラグインのcsファイル入れてエラーないか見る
3. Mod Setting
4. なんかVS2023のなんかのボタンなんか押す(TODO)
5. Build Warudo MOD
6. Playgroundのcsファイルを削除
7. (Warudoを起動している場合)Warudoをアプリケーション丸ごと再起動(シーンの再起動などではだめ)
8. Scripts?(TODO)フォルダに.warudoファイルを配置して最終検証
9. 公開！

### MODのテストからビルドまで
#### Playground

Playgroundフォルダにcsファイルを配置・更新すると、自動でWarudoがビルドしNodeを作成する。
Plyagroundフォルダの場所はWarudoのインストール先`Warudo\Warudo_Data\StreamingAssets\Playground`に存在する。Warudoは基本的にはsteamapps\commonフォルダにインストールされる。
直接このフォルダを探しに行くか、他のProp,Music,Imageフォルダを把握しているなら同階層に存在しているのでそこから辿っても良いだろう。

(TODO)Windows ExplorerのPlaygroundフォルダの内容

(TODO)ここにWarudoEditorの画像

Playgroundでビルドエラーの有無や動作を検証し、テストが完了したらUnityでのビルドに移るのがよいだろう。ただし検証環境の問題か、PlaygroundでのビルドとUnity Warudo SDKでのビルドで動作が異なる場合があるため、留意する。最終的にはUnity Warudo SDKのビルドが正になる。

- コードを直接更新する場合、VSCode上でシンタックスハイライトできるのか　後で検証する
- MODビルド後、Playgroundからcsファイルを削除したうえで丸ごと再起動させる

Playgroundからビルドしたノードが存在すると、Unity Warudo SDKからビルドしたノードと競合してしまうため、Playground側のノード情報を削除する。
Playground内のcsファイルをすべて取り除いたのち、Warudoの再起動が必要になる。「シーンのリロード」や「シーンの再起動」ではノード情報が消えないためNG。

#### ビルドUnity

画像を交えて

- New MOD
- Plugin.cs, (Main).csが必要
- なんかVS2023のボタンを押す
- MODセッティングを更新
- MODができたら.warudoを入れるフォルダ
- 例: https://github.com/okakiya/okakiya-warudo-mod/tree/main/gacha

#### MOD公開
- steam用のマークアップ記述方法（ざっくり）
- 日本語と英語両方入れたい
- 画像、動画の追加の仕方
steamアプリやブラウザ上からでないと追加ができない
- .warudoを公開すること
- 頒布して問題ないかどうか
２次配布になっていないかどうかなど。プリセットモデル使おうね

### スクリプトの書き方

- INPUT,OUTPUT,UIDとか

UIDはWebで検索してもらって…各ノード毎に別々の生成したUIDを適用する。

INPUT
OUTPUT
Warudo上での入出力の型を意識する。文字列にするなら、stringの文字列を用意したうえで、それを返すようにした方がよいかも。

- staticまわりがうまくいかない、なんか方法ない・・・？後で検証する
- 詰まったところ(Watchにstring listを食わせた場合、変更の都度ではなくて毎フレーム発火してしまうこと)


## 画像->Prop

まず画像を表示したいだけならスクリーン>画像選択でいい

#### ビルドUnity

画像を交えて説明する

- ビルド設定
- 画像 > スプライト化
- 配置, コライダー設定
- ビルド、デプロイ

# ブループリントあれこれ

## 関数

function系。stringまわりは結構バグるので気をつけろ

## キューイング

画像 + json

## 便利なノード

- アセットをカメラに向ける
