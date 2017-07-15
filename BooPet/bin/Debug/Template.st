<?xml version="1.0" encoding="utf-8" ?>
<Validator>
	<ValidatorConfig>
		<Processor type="$ProcessorType$" path="$ProcessorPath$" />
		<Handler type="$HandlerType$" path="$HandlerPath$"/>
		<Message type="$MessageType$" path="$MessagePath$"/>
	</ValidatorConfig>
	
	<ValidatorFile>
		$Fields:{
			<Field Name="$it.Name$" DataType="$it.DataType$" />
		}$
	</ValidatorFile>
<Validator>