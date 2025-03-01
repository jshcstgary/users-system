/** @type {import('tailwindcss').Config} */

module.exports = {
	content: ["./node_modules/flyonui/dist/js/*.js", "./src/**/*.{html,ts}"],
	theme: {
		extend: {}
	},
	plugins: [require("flyonui"), require("flyonui/plugin")]
};
