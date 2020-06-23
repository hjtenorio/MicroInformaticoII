const path = require('path');
const { override, addBabelPreset, addWebpackAlias, addWebpackResolve, fixBabelImports, addLessLoader } = require('customize-cra');
const DirectoryNamedWebpackPlugin = require('directory-named-webpack-plugin');

module.exports = override(
  addBabelPreset([
    '@emotion/babel-preset-css-prop',
    {
      autoLabel: true,
      labelFormat: '[local]',
    },
  ]),
  fixBabelImports('import', {
    libraryName: 'antd',
    libraryDirectory: 'es',
  }),
  addWebpackAlias({
    '@valtx-mi2/core': path.resolve(__dirname, 'src/modules/core'),
    '@valtx-mi2/assets': path.resolve(__dirname, 'src/modules/assets'),
    '@valtx-mi2/identity': path.resolve(__dirname, 'src/modules/identity'),
    '@valtx-mi2/ui': path.resolve(__dirname, 'src/modules/ui'),
  }),
  addWebpackResolve({
    plugins: [
      new DirectoryNamedWebpackPlugin({
        honorIndex: true,
        exclude: /node_modules/,
      }),
    ],
  }),
  addLessLoader({
    javascriptEnabled: true,
    hack: `true; @import "mi2.less";`, // Override with less file
  })
);
