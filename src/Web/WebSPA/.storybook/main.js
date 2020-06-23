const path = require('path');
module.exports = {
  stories: ['../src/**/*.stories.[tj]sx'],
  addons: ['@storybook/preset-create-react-app'],
  webpackFinal: async (config, { configType }) => {
    // `configType` has a value of 'DEVELOPMENT' or 'PRODUCTION'
    // You can change the configuration based on that.
    // 'PRODUCTION' is used when building the static version of storybook.

    // Make whatever fine-grained changes you need
    config.module.rules.push({
      test: /\.less$/,
      use: [
        {
          loader: 'style-loader', // creates style nodes from JS strings
        },
        {
          loader: 'css-loader', // translates CSS into CommonJS
        },
        {
          loader: 'less-loader', // compiles Less to CSS
          options: {
            javascriptEnabled: true,
          },
        },
      ],
    });

    config.module.rules.push({
      test: /\.(DOCX)$/i,
      use: [
        {
          loader: 'file-loader',
        },
      ],
    });

    config.resolve.alias = {
      ...config.resolve.alias,
      '@valtx-mi2/core': path.resolve(__dirname, '../src/modules/core'),
      '@valtx-mi2/assets': path.resolve(__dirname, '../src/modules/assets'),
      '@valtx-mi2/identity': path.resolve(__dirname, '../src/modules/identity'),
      '@valtx-mi2/ui': path.resolve(__dirname, '../src/modules/ui'),
    };

    // Return the altered config
    return config;
  },
};
