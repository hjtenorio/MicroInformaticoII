const path = require('path');

module.exports = {
  env: {
    browser: true,
    es6: true,
    node: true,
  },
  extends: ['airbnb', 'prettier', 'prettier/react'],
  globals: {
    Atomics: 'readonly',
    SharedArrayBuffer: 'readonly',
  },
  parserOptions: {
    ecmaFeatures: {
      jsx: true,
    },
    ecmaVersion: 2018,
    sourceType: 'module',
  },
  plugins: ['react', 'prettier'],
  settings: {
    'import/parsers': {
      'babel-eslint': ['.js'],
    },
    'import/resolver': {
      alias: [
        ['@valtx-mi2/core', path.resolve(__dirname, 'src/modules/core')],
        ['@valtx-mi2/assets', path.resolve(__dirname, 'src/modules/assets')],
        ['@valtx-mi2/identity', path.resolve(__dirname, 'src/modules/identity')],
        ['@valtx-mi2/ui', path.resolve(__dirname, 'src/modules/ui')],
      ],
    },
  },
};
