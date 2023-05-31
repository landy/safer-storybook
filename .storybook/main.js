/** @type { import('@storybook/react-vite').StorybookConfig } */
const config = {
  stories: ["../src/SaferStorybook.Client/.fable-build/**/*.mdx", "../src/SaferStorybook.Client/.fable-build/**/*.stories.@(js|jsx|ts|tsx)"],
  addons: [
    "@storybook/addon-links",
    "@storybook/addon-essentials",
    "@storybook/addon-interactions",
  ],
  framework: {
    name: "@storybook/react-vite",
    options: {},
  },
  docs: {
    autodocs: "tag",
  },
};
export default config;