# 🚀 3D Gaussian Splattingのパススルー機能追加 

## ※このプロジェクトは [UnityGaussianSplatting](https://github.com/aras-p/UnityGaussianSplatting) を基に開発しました。

![Unity Gaussian Splatting VR Video](images/UnityGSVR.gif)  

---

## 🎯 概要

このプロジェクトは、**3D Gaussian Splatting を VR 空間で視認し、パススルー環境での活用を可能にしたサンプルアプリ** です。  
**Scaniverse** で撮影したデータを VR で視認し、**手の動作でメモとして線を引く機能を追加** しました。

📌 **最新の 3D Gaussian Splatting 技術を活用し、実物大の 3D スキャンデータを VR で視認**  
📌 **手のジェスチャーで線を描画・削除し、メモ機能として活用**  
📌 **Quest のパススルー機能を活用し、背景と融合した 3D モデルの表示を実現**

---

## 🎨 3D Gaussian Splatting の活用
- **3D Gaussian Splatting** をパススルー環境で視認可能（録画時には背景が黒くなっていますがパススルー表示可能です）
- **ハノーバーメッセ（2024年 ドイツ）で撮影したオブジェを VR で視認**
- **Scaniverse で撮影したデータを活用し、実物大での確認が可能**
- **他の 3D Gaussian Splatting データも利用可能**

📌 **新しい 3D スキャン技術を VR で活用することに重点を置いたプロジェクトです。**

---

## 🖐️ ハンドトラッキングによる操作
- **コントローラー不要、ハンドトラッキングのみで操作可能**
- **親指と人差し指でつまむと線を描画**
- **左手のひらを顔に向けた状態でつまむと線をリセット**
- **右手のひらを顔に向けて長くつまむと、正面がリセットされ3Dオブジェクトを移動可能**

---

## 🛠 使用技術
| 技術 | 詳細 |
|------|------|
| Unity | 2022.3.16f1 |
| C# | .NET Standard |
| Scaniverse | iOS 4.0.5 |

---

## 📥 アプリの使用方法

1. **Quest の開発者モードを有効化**
2. `build` ディレクトリにある `apk` ファイルを **Meta Quest シリーズ** にインストール
3. ヘッドセットからアプリを起動し、3D Gaussian Splatting を VR で視認

## 📥 プロジェクトの使用方法

`projects` > `GaussianExample-URP`を対応するバージョンのUnityEditorで開いてください

---

## 🎮 確認済み動作環境

✅ **Meta Quest 3**  
✅ **Meta Quest 2**（⚠️ パススルーは灰色表示、録画時に背景が黒くなる）  

---

## 🚀 機能

### 🎨 3D Gaussian Splatting のパススルー表示
- **背景が透過した状態で 3D Gaussian Splatting を視認**
  
### 🔄 ガーディアン非表示機能
- **VR の「ガーディアン」機能を OFF にして、自由に移動可能**

### 🖐️ ハンズフリーの操作
- **右手親指と人差し指でつまむと線の描画**
- **左手のひらを顔に向けてつまむと全ての線を削除**
- **右手のひらを顔に向けて長くつまむとオブジェクトを移動**

---

## 🛠 技術的工夫

📌 **ハンドトラッキングを活用した直感的な操作**
- **手のジェスチャーを利用し、コントローラーなしで操作**

📌 **3D Gaussian Splatting の VR 環境最適化**
- **背景を透過して、リアル空間と融合**

📌 **VR 体験の向上**
- **ガーディアン非表示で、体験の煩わしさを解消**

---

## 📚 参考資料

🔗 **ドキュメント**  
[📄 Meta XRパッケージドキュメント](https://developers.meta.com/horizon/documentation/unity/unity-package-manager/?locale=ja_JP)  

🔗 **引用文献**  
[📖 Unity Gaussian Splatting リポジトリ](https://github.com/aras-p/UnityGaussianSplatting)  
[📖 【Unity】Questのハンドトラッキングで特定の手の形を認識して処理を走らせる](https://qiita.com/SousiOmine/items/4d07c1bea48fa9b63a93)  
[📖 境界線なし](https://developers.meta.com/horizon/documentation/unity/unity-boundaryless?locale=ja_JP)  
