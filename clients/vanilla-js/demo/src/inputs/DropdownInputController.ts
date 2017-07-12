import * as umf from "../../../src/core/index";

export class DropdownInputController extends umf.InputController<DropdownValue> {
	selected: string;

	serialize(): Promise<{ value: string, input: DropdownInputController }> {
		return new Promise((resolve, reject) => {
			resolve({
				value: this.selected,
				input: this
			})
		});
	}

	init(value: string): Promise<DropdownInputController> {
		return new Promise((resolve, reject) => {
			this.selected = value;
			this.value = this.parse(value);
			resolve(this);
		});
	}

	getValue(): Promise<DropdownValue> {
		return Promise.resolve(this.parse(this.selected));
	}

	private parse(value: string): DropdownValue {
		return value == null || value == "" ? null : { value: value };
	}
}

class DropdownValue {
	value: string;
}