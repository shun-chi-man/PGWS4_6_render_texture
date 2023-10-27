# テクスチャ描画
テクスチャに対してレンダリングを行います。

## バックミラー
![結果画像1](result1.gif)

## 水シミュレーション
![結果画像2](result2.gif)

![結果画像3](result3.gif)

![結果画像4](result4.gif)

## 自分なりにかっこいいシーン

![wave_1](https://github.com/shun-chi-man/PGWS4_6_render_texture/assets/146050674/2b2e74dc-eb9d-4f71-b62c-62368e7d39b8)

![Water ShaderGraph2](https://github.com/shun-chi-man/PGWS4_6_render_texture/assets/146050674/d4ac9d69-dd07-4267-a2f3-12133321d561)


# 自分なりに変更した点
- SubdivPlaneにアタッチしたシェーダーグラフに色の変更を加え、水面と波のような表現にしました。
- Sphereの軌道を円を描くような運動に変えました。
- 対称性のある波紋にしました。


# 進め方

- 本リポジトリをフォークしてください
- フォークしたリポジトリをcloneします
- Unityのプロジェクトを更新して実装してください。
  - 結果画像1（1番上の画像）と同じシーンを「1 Render Texture Scene」に実現してください
  - 結果画像2（2番目の画像）と同じシーンを「2 RT Layer Scene」に実現してください
  - 結果画像3（3番目の画像）と同じシーンを「3 PingPong Scene」に実現してください
  - 結果画像4（4番目の画像）と同じシーンを「4 Wave Simulation Scene」に実現してください
  - 自分なりにかっこいいシーンを「My Best Scene」に作成してください
- 「My Best Scene」の結果をUnity RecorderでAnimation GIFとして保存し、result.gifという名前にして本ディレクトリの物と差し替えてください（サイズが大きくて上げられない場合は、解像度を小さくするなどして下さい）
- node_graph.pngを自分のシェーダグラフの一番頑張ったノードと差し替えてください
- このテキストファイルに変更点を記載してください
- プルリクエストを出して提出してください
