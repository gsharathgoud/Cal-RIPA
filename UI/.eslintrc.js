module.exports = {
  root: true,
  env: {
    node: true,
  },
  extends: ['plugin:vue/essential', '@vue/standard', '@vue/prettier'],
  parserOptions: {
    parser: 'babel-eslint',
  },
  rules: {
    'array-callback-return': 'warn',
    eqeqeq: 'warn',
    'import/no-duplicates': 'warn',
    'import/no-extraneous-dependencies': 'off',
    'import/no-named-default': 'warn',
    'import/no-webpack-loader-syntax': 'off',
    'linebreak-style': ['off', 'unix'],
    'no-console': 'off',
    'no-debugger': process.env.NODE_ENV === 'production' ? 'warn' : 'off',
    'no-dupe-keys': 'warn',
    'no-labels': 'off',
    'no-nested-ternary': 'off',
    'no-prototype-builtins': 'warn',
    'no-return-await': 'warn',
    'no-sequences': 'off',
    'no-throw-literal': 'off',
    'no-undef': 'warn',
    'no-unreachable': 'warn',
    'no-unused-expressions': 'warn',
    'no-unused-vars': 'warn',
    'no-var': 'warn',
    'prettier/prettier': [
      'warn',
      {
        htmlWhitespaceSensitivity: 'strict',
        semi: false,
        singleQuote: true,
      },
    ],
    'quote-props': ['warn', 'as-needed'],
    'vue/experimental-script-setup-vars': 'off',
    'vue/no-dupe-keys': 'warn',
    'vue/no-mutating-props': 'off',
    'vue/no-side-effects-in-computed-properties': 'warn',
    'vue/no-unused-components': 'warn',
    'vue/no-unused-vars': 'warn',
    'vue/require-component-is': 'warn',
    'vue/require-v-for-key': 'warn',
    'vue/return-in-computed-property': 'warn',
    'vue/valid-v-for': 'warn',
    'vue/valid-v-slot': [
      'error',
      {
        allowModifiers: true,
      },
    ],
  },
  overrides: [
    {
      files: [
        '**/__tests__/*.{j,t}s?(x)',
        '**/tests/unit/**/*.spec.{j,t}s?(x)',
      ],
      env: {
        jest: true,
      },
    },
  ],
}
